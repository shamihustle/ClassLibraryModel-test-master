using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements.View
{
    [Serializable]
    public class ElementsProject
    {
        private double _angularFrequency;

        public double AngularFrequency
        {
            get { return _angularFrequency; }

            set
            {
                if (value < 0 || value > 999)
                {
                    throw new ArgumentException(@"Error with angular frequency");
                }
                _angularFrequency = value;
            }
        }

        public string FileName { get; set; }
        public List<IElement> Elements { get; set; }

        public ElementsProject(double angularFrequecy, List<IElement> elements, string filename)
        {
            AngularFrequency = angularFrequecy;
            Elements = elements;
            FileName = filename;
        }

        public ElementsProject()
        {
            
        }
    }
}
