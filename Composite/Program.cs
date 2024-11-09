var file1 = new Composite.File("File1.txt", 120);
var file2 = new Composite.File("File2.txt", 80);

var folder1 = new Composite.Directory("Folder1");
folder1.Add(file1);
folder1.Add(file2);

var mainFolder = new Composite.Directory("MainFolder");
var file3 = new Composite.File("File3.txt", 160);
mainFolder.Add(folder1);
mainFolder.Add(file3);

mainFolder.Display();
