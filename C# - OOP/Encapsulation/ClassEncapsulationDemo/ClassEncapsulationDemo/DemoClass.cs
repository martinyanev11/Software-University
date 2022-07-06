using System;
using System.Collections.Generic;
using System.Text;

namespace ClassEncapsulationDemo
{
    /* GENERAL RULES:
       Hide all data that shouldn't be accessible outside the class
       Always start with the highest encapsulation level and go down form there if needed
     ----------------------------------------------------------------------
     Access modifiers:
        - private
        - protected
        - internal
        - public
    ----------------------------------------------------------------------
     General setup:
        conts, fields -> private
        Constructors -> private, protected, public
        Properties -> public getter;    private, protected setter
        Methods -> private, protected, public
    ----------------------------------------------------------------------
     DEMO:*/

    class DemoClass
    {
        // 1.Fields at the top
        private int fieldDemo;
        private readonly List<string> strListField; // collections are reference type, default value == null
        private readonly Dictionary<string, bool> dictField;
        // readonly -> set only once when initialized, cannot be changed after that


        // 2.Constructors after fields
        private DemoClass() // private ctor user only for initialization of collections
        {
            this.strListField = new List<string>();
            this.dictField = new Dictionary<string, bool>();
        }

        // general public ctor to create instances of the class
        public DemoClass(int demoInitInput)
            : this() // chain the ctors
        {
            // in ctor use props not fields!
            this.MyPropertyDemo = demoInitInput;
        }

        // 3.Properties after ctors
        public int MyPropertyDemo
        {
            get // its okay to be public so outside can see information about properties
            { 
                return fieldDemo; 
            }
            private set // makes it that nobody can change value without ctor anymore
                        // (e.g. outside cant say demoClassInstance.MyPropertyDemo = 10)
            { 
                fieldDemo = value; 
            }
        }

        // When making collection in property always make it return IReadOnlyCollection
        // IReadOnlyCollecton -> forbids Add(); Insert(); Remove(); Clear(); etc...
        public IReadOnlyCollection<string> StringListProperty // usually collections are made readonly and without setter
        {
            get 
            { 
                return this.strListField; 
            }
        }

        public IReadOnlyDictionary<string, bool> DictionaryListProterty
        {
            get
            {
                return this.dictField;
            }
        }

        // 4.Methods are at the bottom of the class
        public void MethodDemo()
        {
            throw new NotImplementedException();
        }
    }
}
