using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;


namespace lab1 {
  [TestFixture]
  class Program {

    public static void Main()
    { 
      List<object> l = new List<object>() {1,2,'a','b',"aasf",'1',"123",231};
      var a = get_integers_from_list(l);
	    foreach(var it in a) {
		    Console.WriteLine(it);
	    }
      Console.WriteLine(first_non_repeating_letter("sseeptmbeer"));
      Console.WriteLine(digital_root(999));
      int[] i = {5,2,0,2,7,4,5};
      Console.WriteLine(num_of_pairs(i, 7));
      Console.WriteLine(conv_string("Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill"));
    }
//task1 tests
    [Test]
    public void verify_get_integers_from_list_equal(){
            var expected_list = new List<int>(){1, 2, 231};
            var returned_list = get_integers_from_list(new List<object>(){1, 2, 'a', 'b', "aasf", '1', "123", 231});
            Assert.AreEqual(expected_list,returned_list,
                        message:"Expected {1, 2, 231}, got {" + String.Join(", ", returned_list) +"}" );
        }
    [Test]
    public void verify_get_integers_from_list_not_equal(){
        var rand_list = new List<int>(){1, 2, 321};
        Assert.AreNotEqual(list,get_integers_from_list(new List<object>(){1, 2, 'a', 'b', "aasf", '1', "123", 123, 231}));

        rand_list = new List<int>(){1, 2, 123, 321};
        Assert.AreNotEqual(list,get_integers_from_list(new List<object>(){1, 2, 'a', 'b', "aasf", '1', "123", 231}));
    }
//task2 tests
    [Test]
    public void verify_first_non_repeating_letter_equal(){
        char expected_letter = 'p';
        Assert.AreEqual(expected_letter,first_non_repeating_letter("sseeptmbeer"));

        expected_letter = 'T';
        Assert.AreEqual(expected_letter,first_non_repeating_letter("ssEeppTmbEer"));

        expected_letter = '\0';
        Assert.AreEqual(expected_letter,first_non_repeating_letter(""));
    
    }
    
    [Test]
    public void verify_first_non_repeating_letter_not_equal(){
        char expected_letter = 'e';
        Assert.AreNotEqual(expected_letter,first_non_repeating_letter("sseeptmbeer"));

        expected_letter = 'e';
        Assert.AreNotEqual(expected_letter,first_non_repeating_letter("sseptEmbEr"));
    }
//task3 tests
    [Test]        
    public void verify_num_of_pairs_equal(){
        var expected_result = 5;
        Assert.AreEqual(expected_result,num_of_pairs(new List<int>(){5,2,0,2,7,4,5},7));

        expected_result = 0;
        Assert.AreEqual(expected_result,num_of_pairs(new List<int>(){1,1,1,1,1}, 1));
    } 
    [Test]        
    public void verify_num_of_pairs_not_equal(){
        var expected_result = 3;
        Assert.AreNotEqual(expected_result,num_of_pairs(new List<int>(){5,2,0,2,7,4,5},7));

        expected_result = 4;
        Assert.AreNotEqual(expected_result,num_of_pairs(new List<int>(){1,2,3,2,3,4,1},1));
    } 

//task4 tests
    [Test]
    public void verify_digital_root_equal(){
        var expected_result = 3;
        Assert.AreEqual(expected_result,digital_root(111));


        expected_result = 9;
        Assert.AreEqual(expected_result,digital_root(999));

    }

    [Test]
    public void verify_digital_root_not_equal(){
        var expected_result = 1;
        Assert.AreNotEqual(expected_result,digital_root(111));


        expected_result = 27;
        Assert.AreNotEqual(expected_result,digital_root(999));
    }

//task5 tests
    [Test]
    public void verify_conv_string_equal() {
      var expected_string = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
      var returned_string = conv_string("Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill");

      Assert.AreEqual(expected_string, returned_string);
    }

    [Test]
    public void verify_conv_string_not_equal() {
      var expected_string = "Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
      var returned_string = conv_string("Fired:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill");

      Assert.AreNotEqual(expected_string, returned_string);
    }

    
    // task1
    public static List<int> get_integers_from_list(List<object> l1) 
    {
      List<int> newlist = new List<int>();
      foreach(object i in l1) {
        if (i.GetType() == typeof(int)) {
          newlist.Add(Convert.ToInt32(i));
        }
      }
      return newlist;
    } 

    // task2
    public static string first_non_repeating_letter(string str){
      string str_low = str.ToLower();
      var letters = new Dictionary<char, int>();
      foreach(char i in str_low) {
        if (letters.ContainsKey(i))
                    letters[i] += 1;
                else
                    letters.Add(i, 1);
      }
      for (int i = 0; i < str.Length; i++) {
        if (letters[str_low[i]] == 1) {
          return Convert.ToString(str[i]);
        }
      }
      return "";
    }

    // task3
    public static int digital_root(int num) {
      string n1 = Convert.ToString(num);
      int sum = 0;
      while (num != 0) {
          sum += num % 10;
          num /= 10;
      }
      
      if (sum > 9) {
        sum = digital_root(sum);
      }
      return sum;
    }

    // task4
    public static int num_of_pairs(int[] nums, int target) {
      int counter = 0;
      for(int i = 0; i < nums.Length; i++) {
        for(int j = i+1; j < nums.Length; j++) {
          if(nums[i] + nums[j] == target) {
            counter += 1;
          }
        }
      }
      return counter;
    }

    // task5
    public static string conv_string(string guests) {
      guests = guests.ToUpper();
      string[] l1 = guests.Split(';');
      List<Tuple<string, string>> guests_list = new List<Tuple<string, string>>();
      foreach(string i in l1) {
        string[] nume_surname = i.Split(':');
        guests_list.Add(Tuple.Create(nume_surname[1], nume_surname[0]));
      }
      guests_list.Sort();
  	  string res = "";
      foreach(var i in guests_list) {
        res += "(" + i.Item1 + ", " + i.Item2 + ")";
      }
      return res;
    } 
  }
}
