using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.Design.Serialization;
using System.Reflection;
using System.Runtime.InteropServices;


namespace SpellWork
{
    // DynamicObject from http://rsdn.ru/
    class CollectionTypeConverter : TypeConverter
    {
        /// <summary>
        /// Только в строку
        /// </summary>
        public override bool CanConvertTo(
          ITypeDescriptorContext context, Type destType)
        {
            return destType == typeof(string);
        }

        /// <summary>
        /// И только так
        /// </summary>
        public override object ConvertTo(
          ITypeDescriptorContext context, CultureInfo culture,
          object value, Type destType)
        {
            StringBuilder SB= new StringBuilder();
            Array a = (Array)value;
            for (int i = 0; i < a.Length; i++)
              {
                SB.AppendFormat("{0}{1}", a.GetValue(i).ToString(),i<(a.Length-1)? ";":"");
              }
            return String.Format("{0}[{1}] ({2})", value.GetType().GetElementType().Name,a.Length,SB.ToString());
        }
        
    }

    public class DynamicObject : ICustomTypeDescriptor
    {
        public SpellEntry Spell;
        public DynamicObject (SpellEntry S)
        {
            Spell = S;
            foreach (FieldInfo f in Spell.GetType().GetFields())
                AddProperty(f);
        }

        private string _Filter = String.Empty;
        private PropertyDescriptorCollection _FilteredPropertyDescriptors = new PropertyDescriptorCollection(null);
        private PropertyDescriptorCollection _FullPropertyDescriptors = new PropertyDescriptorCollection(null);

        public void AddProperty(FieldInfo f )
        {
            string name = f.Name;
            string displayName = f.Name;
            string description = f.Name;
            string category = "";
         
            var attrs =  new List<Attribute>();

            if (!String.IsNullOrEmpty(displayName))
                attrs.Add(new DisplayNameAttribute(displayName));

            if (!String.IsNullOrEmpty(description))
                attrs.Add(new DescriptionAttribute(description));

            if (!String.IsNullOrEmpty(category))
                attrs.Add(new CategoryAttribute(category));

            if (f.FieldType.IsArray)
                attrs.Add(new TypeConverterAttribute(typeof(CollectionTypeConverter)));

            _FullPropertyDescriptors.Add(new GenericPropertyDescriptor/*<T>*/(
              name, attrs.ToArray(),this));
        }


        public void RemoveProperty(string propertyName)
        {
            var descriptor = _FullPropertyDescriptors.Find(propertyName, true);
            if (descriptor != null)
                _FullPropertyDescriptors.Remove(descriptor);
            else
                throw new Exception("Property is not found");
        }


        public string Filter
        {
            get { return _Filter; }
            set
            {
                _Filter = value.Trim().ToLower();
                if (_Filter.Length != 0)
                    FilterProperties(_Filter);
            }
        }

        private void FilterProperties(string filter)
        {
            _FilteredPropertyDescriptors.Clear();
            List<string> props =new List<string>(); // = filter.Split(';');
            props.AddRange(filter.Split(';'));

            foreach (string p in props)
            {
                PropertyDescriptor descriptor = _FullPropertyDescriptors.Find(p, true);
                if (descriptor != null)
                    _FilteredPropertyDescriptors.Add(descriptor);
                else
                {
                   descriptor = _FullPropertyDescriptors.Find(p.ArrayName(), true);
                   if (descriptor != null)
                   {
                       if ( _FilteredPropertyDescriptors.IndexOf(descriptor) <0 )
                       _FilteredPropertyDescriptors.Add(descriptor);
                   }
                }
            }
        }


        public object this[string propertyName]
        {
            get { return GetPropertyValue(propertyName); }
            set { SetPropertyValue(propertyName, value); }
        }

        private object GetPropertyValue(string propertyName)
        {
            var descriptor = _FullPropertyDescriptors.Find(propertyName, true);
            if (descriptor != null)
                return descriptor.GetValue(null);
            else
                throw new Exception("Property is not found");
        }

        private void SetPropertyValue(string propertyName, object value)
        {
            var descriptor = _FullPropertyDescriptors.Find(propertyName, true);
            if (descriptor != null)
                descriptor.SetValue(null, value);
            else
                throw new Exception("Property is not found");
        }



        #region Implementation of ICustomTypeDescriptor

        public System.ComponentModel.TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        public System.ComponentModel.EventDescriptorCollection GetEvents(System.Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        public System.ComponentModel.EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        public string GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        public object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd)
        {
            return this;
        }

        public System.ComponentModel.AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        public System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes)
        {
            if (_Filter.Length != 0)
            {
                return _FilteredPropertyDescriptors;
            }
            else
            {
                return _FullPropertyDescriptors;
            }
        }

        public System.ComponentModel.PropertyDescriptorCollection GetProperties()
        {
            return GetProperties(new Attribute[0]);
        }

        public object GetEditor(System.Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        public System.ComponentModel.PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        public System.ComponentModel.EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        #endregion
    }

    public class GenericPropertyDescriptor/*<T>*/ : PropertyDescriptor
    {
        DynamicObject _SE;
        FieldInfo f;
        public GenericPropertyDescriptor(string name, Attribute[] attrs, DynamicObject S)
            : base(name, attrs)
        {
            _SE=S;
            f = typeof(SpellEntry).GetField(name);
        }



        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override System.Type ComponentType
        {
            get
            {
                return typeof(GenericPropertyDescriptor/*<T>*/);
            }
        }

        public override object GetValue(object component)
        {
            return f.GetValueDirect(__makeref(_SE.Spell));
        }

        public override bool IsReadOnly
        {
            get
            {
                return Array.Exists(this.AttributeArray, attr => attr is ReadOnlyAttribute);
            }
        }

        public override System.Type PropertyType
        {
            get
            {
                return f.FieldType;
            }
        }

        public override void ResetValue(object component)
        {
        }

        public override void SetValue(object component, object value)
        {
            f.SetValueDirect(__makeref(_SE.Spell), /*(T)*/value);
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
    }
}
