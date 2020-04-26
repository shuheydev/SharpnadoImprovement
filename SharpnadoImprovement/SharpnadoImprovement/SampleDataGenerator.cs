using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SharpnadoImprovement
{
    public static class SampleDataGenerator
    {
        public static ObservableCollection<Person> GetPeople()
        {
            List<Person> source = new List<Person>();

            for (int i = 1; i <= 10; i++)
            {
                source.Add(new Person
                {
                    Name = $"Name{i}",
                    ImageSrc = ImageSource.FromResource($"SharpnadoImprovement.Resources.Images.avatar_men_{i}.jpg")
                }); ;
            }

            return new ObservableCollection<Person>(source);
        }

    }
}
