using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark_testing
{
    public class Filter
    {
        //the method to sort the name in alphabetical
        public List<MyClass> SortAZ(List<MyClass> sList)
        {
            //use a Linq lambda expression to put the name in ascending order according to Name, and store it to sList
            sList = sList.OrderBy(x => x.Name).ToList();

            //return as sList
            return sList;
        }

        //the method to sort name in reverse order of the alphabet
        public List<MyClass> SortZA(List<MyClass> sList)
        {
            // from x in a source file, and order its name to descending order, then select
            // is and convert it to a list and store it to slist which is a list of MyClass type
            sList = (from x in sList
                     orderby x.Name descending
                     select x).ToList();

            //return as sList
            return sList;
        }
        //the method to search name
        public List<MyClass> Search(List<MyClass> sList, string term)
        {
            //Initializing variable results which is a list of MyClass
            List<MyClass> results = new List<MyClass>();

            //Search for each MyClass s in sList which have entire MyClass list
            foreach (MyClass s in sList)
            {
                //If Name which already converted to lowercase contains the term which already converted to lowercase
                if (s.Name.ToLower().Contains(term.ToLower()))
                {
                    //Keep adding the Name which contains the term to list box
                    results.Add(s);
                }
            }

            //return as results
            return results;
        }
    }
}
