
using ISPViolation.Domain;

Manager man1 = new Manager();
Robot robot = new Robot();

robot.StartEating(); //this will give an error at runtime(not compile time since we have defined the fn StartEating in rebot and asked it to throw an exception
robot.StartWorking();

man1.StopWorking();
man1.StopEating();

