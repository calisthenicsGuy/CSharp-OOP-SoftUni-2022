﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animals
    {
        private const string ERROR_MESSAGE = "Invalid input!";

        private string name;
        private int age;
        private string gender;

        public Animals(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age; 
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ERROR_MESSAGE);
                }
                this.name = value;
            }
        }

        public int Age 
        {
            get
            {
                return age;
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException(ERROR_MESSAGE);
                }
                this.age = value;
            } 
        }

        public string Gender 
        {
            get 
            { 
                return gender; 
            }
            set 
            {
                if (value != "Male" || value != "Female")
                {
                    throw new ArgumentException(ERROR_MESSAGE);
                }
                this.gender = value;
            }
        }

        protected abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine($"{this.ProduceSound()}");

            return sb.ToString().TrimEnd();
        }
    }
}
