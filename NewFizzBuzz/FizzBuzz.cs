for (int i = 1; i <= 50; i++)
{
    var response = (i % 3, i % 5) switch
    {
        (0, 0) => "fizz buzz",
        (0, _) => "fizz",
        (_, 0) => "buzz",
        _ => i.ToString(),
    };
    Console.WriteLine(response);
}
