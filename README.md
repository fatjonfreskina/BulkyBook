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

## Controllers folder

HomeController.cs : always end the name with Controller. 

HomeController will create a Home Folder in view. All the views or ui displayed with the home controller will be placed in the home folder.

## Views folder

```
Views  
│   _ViewImports.cshtml // import namespaces; @taghelpers
│   _ViewStart.cshtml
│
├───Home
│       Index.cshtml
│       Privacy.cshtml
│
└───Shared
        Error.cshtml
        _Layout.cshtml
        _Layout.cshtml.css
        _ValidationScriptsPartial.cshtml
  ```
  
There is a main layout defined in \_Layout.cshtml (containing head, header, nav bar, footer, imports..) and a div that gets filled with the appropriate content in the Home folder. 

TagHelpers look like html tags but start with `asp`: asp-controller; asp-action
