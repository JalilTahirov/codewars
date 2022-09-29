using System;
public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    
    var strArray = phrase.Split(" ");
    for(int i = 0; i < strArray.Length; i++){
      strArray[i] = MakeUpper(strArray[i]);      
    }
    
    return String.Join(" ", strArray);
  }
  
  public static string MakeUpper(string word){
    return char.ToUpper(word[0]) + word.Substring(1);
  }
  
}
