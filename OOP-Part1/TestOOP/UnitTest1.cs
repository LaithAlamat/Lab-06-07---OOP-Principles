using System;
using Xunit;
using OOP_Part1;

namespace TestOOP
{
    public class UnitTest1
    {
        [Fact]
        public void LionTest()
        {
            Assert.True(typeof(Lion).IsSubclassOf(typeof(Animal)));
        }
        
        [Fact]
        public void ExibitBehaivourFromBaseClass()
        {
            Duck ducky = new Duck();
            Bear bear = new Bear();

            Assert.Equal("Ducks eat grass", ducky.Eat());
            Assert.Equal("All Bears eat", bear.Eat());
        }
        [Fact]
        public void InterfaceImplementation()
        {
            Lion Laith = new Lion();
            

            Assert.Equal("All Lions run", Laith.run());
        }

        [Fact]
        public void Inheritance()
        {
            Cow rachel = new Cow();

            Assert.Equal("All Cows sleep", rachel.Sleep());// inherited from Mammals
        }

        [Fact]
        public void Ploymorphism()
        {
            Mamels lion = new Lion();  // SiberianHusky is a dog
            
            lion.Eat();


            Assert.Equal("All Lions eat", lion.Eat());
        }
    }
}
