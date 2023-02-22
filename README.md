# BulkyBook

## About MVC

We can simplify and say that tipically for each table in the DB you have a Model class that represents it. All the properties of the class file will be the the columns of tha table.

The view can be thought as html and css. 

If you click a button in the view, it interacts with the model by means of the controller. 

## About routing

https://localhost:55555/{controller}/{action}/{id}

In program.cs you have 

```cs
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
```

If controller and action are not defined in the request they will be these ones as default

## Controllers

HomeController.cs : always end the name with Controller. 

HomeController will create a Home Folder in view. All the views or ui displayed with the home controller will be placed in the home folder.
