# MassDownload
A program to get multiple files from download links provided on a website (Quite naive - intended mainly as a basis for demonstrating async programming.)  

E.g.  
  ```
  dotnet run https:minorplanetcenter.net/data "neam.*\.json\.gz$" "c:\temp\downloads"
  ```
  ```
  dotnet run http:compling.hss.ntu.edu.sg/omw "\.zip$" "c:\temp\downloads"
  ```
  Large!   
  ```
  dotnet run http:storage.googleapis.com/books/ngrams/books/datasetsv2.html "eng\-1M\-2gram.*\.zip$" "c:\temp\downloads"
  ```
  
  ![[output-example.PNG]]