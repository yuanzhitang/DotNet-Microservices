Motivation
When we design an application we should take care how we are going to make abstract a module which contains several submodules. 
Considering the module implemented by a class, we can have an abstraction of the system done in an interface. But if we want to 
extend our application adding another module that contains only some of the submodules of the original system, we are forced to 
implement the full interface and to write some dummy methods. Such an interface is named fat interface or polluted interface. 
Having an interface pollution is not a good solution and might induce inappropriate behavior in the system.

The Interface Segregation Principle states that clients should not be forced to implement interfaces they don't use. 
Instead of one fat interface many small interfaces are preferred based on groups of methods, each one serving one submodule.

Intent
Clients should not be forced to depend upon interfaces that they don't use.