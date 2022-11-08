using Builder;


var element = HtmlElement.Create("ul")
    .AddChild("li", "hello")
    .AddChild("li", "world")
    .AddChild("li", "F1")
    .AddChild("li", "F2")
    .AddChild("li", "CCS")
    .Build();



Console.WriteLine(element);
