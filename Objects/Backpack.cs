using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Backpack
    {
        /*  //public is for outside of this class
          private string _material;
          private int _pocket;
          private string _color;
          private string _size;
          ///<summary>
          ///this is pound
          ///</summary>
          private double _weight;
          private bool _havewheels;

          public void setMaterial(string material)
          {
              _material = material;
          }

          public string getMaterial()
          {
              return _material;
          }
          public void setPocket(int pocket)
          {
              _pocket = pocket;
          }

          public int getPocket()
          {
              return _pocket;
          }
          public void setColor(string color)
          {
              _color = color;
          }
          public string getColor()
          {
              return _color;
          }
          public void setSize(string size)
          {
              _size = size;
          }
          public string getSize()
          {
              return _size;
          }
          public void setWeight(double weight)
          {
              _weight = weight;
          }
          public double getWeight() {
              return _weight;
          }

          public void setHavewheels(bool havewheels)
          {
              _havewheels = havewheels;
          }
          public bool getHavewheels()
          {
              return _havewheels;
          }*/




            //if needs validation (Ex. email, social media account) you use INTERNAL || PRIVATE, otherwise public
          public void printTheObjectProperties()
          {
              Console.WriteLine($"material: {material}\n" + 
                  $"pocket: {pocket}\n" + 
                  $"color: {color}\n" + 
                  $"size: {size}\n" + 
                  $"weight: {weight}\n" + 
                  $"havewheels: {havewheels}\n" );
          } 
        public string material {
            get; set; }
        public int pocket { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public double weight { get; set; }
        public bool havewheels { get; set; }

    }
}
