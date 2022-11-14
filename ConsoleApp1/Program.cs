using ConsoleApp1.Methods;
using ConsoleApp1.WorkWithFiles;

FileXMLWorker fxmlw = new FileXMLWorker();
MethodsForClss methodsForClss = new MethodsForClss();
fxmlw.writeinfile(methodsForClss.dr_list(5));