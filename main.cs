using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine ("Enter name:");
    string name = Console.ReadLine();
    Console.WriteLine ("Enter height (inches):");
    double height = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter weight (pounds):");
    double weight = double.Parse(Console.ReadLine());

    double bmi = Math.Round((703 * weight) / (height * height), 1);

    Console.WriteLine("BMI = " + bmi );

    if (bmi < 18.5) {
      Status("Underweight", name);
    } else if (bmi > 18.5 && bmi < 24.9) {
      Status("Healthy Weight", name);
    } else if (bmi > 25.0 && bmi < 29.9) {
      Status("Overweight", name);
    } else if (bmi > 30.0) {
      Status("Obese", name);
    }


  }

  public static void Status (string status, string name) {
    Console.WriteLine(name + "'s " + "Health Status: " + status);
  }

}