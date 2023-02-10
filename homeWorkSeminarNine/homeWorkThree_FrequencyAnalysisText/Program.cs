//Провести частотный анализ символов 

string text = "Спят усталые игрушки, книжки спят\n" + 
              "Одеяла и подушки ждут ребят\n" +  
              "Даже сказка спать ложится\n" +  
              "Чтобы ночью нам присниться\n" +  
              "Ты ей пожелай: Баю-бай!";

System.Console.WriteLine(text);
System.Console.WriteLine();

int textLength = text.Length; // нужно для подсчёта процентов

char [] alfabet = {'А','Б','В','Г','Д','Е','Ё','Ж','З',
                  'И','Й','К','Л','М','Н','О','П','Р',
                  'С','Т','У','Ф','Х','Ц','Ч','Ш','Щ',
                  'Ъ','Ы','Ь','Э','Ю','Я',',','.','!',' '};

int[] resultAnalisys = FrequencyАnalysis(text,alfabet);

PrintAnalysis(resultAnalisys,alfabet,textLength);                              



int [] FrequencyАnalysis(string text, char [] library){

char [] textForAnalysis = text.Trim()
                              .ToUpper()
                              .ToCharArray();

int [] countValueAlfabet = new int [library.Length]; 

for (int i = 0; i < textForAnalysis.Length; i++)
{
  for (int j = 0; j < library.Length; j++)
  {
    if (textForAnalysis[i].Equals(library[j])){countValueAlfabet[j] += 1;}
  }
}
return countValueAlfabet;
}


void PrintAnalysis(int[] result, char [] alfabet, float textLength){
  
  for (int i = 0; i < result.Length; i++)
  {
    System.Console.WriteLine($"Символ {alfabet[i]} встречаеться в тексте {result[i]} раз," + 
     $"это = {textLength/100*(float)result[i]}%");
  }
}