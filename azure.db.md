# Notes for Assignment 3
## DB in Azure

1. create SQL database
2. name it whenever
3. use SQL authentication
4. create admin login ***save this***
5. `compute + storage` "Basic" (2GB storage)
   - make sure its about $4.90 a month!
6. `Production` env
7. wait to deploy
8. networking > public network access > `selected networks`
   - allow azure services to access this server
   - add client IP addresses to firewall
9. SQL databases > your server > show database connection string ***save this***
   - add password to connection string 
10. `appsettings.json` add the connection string to line 3 (`defaultConnection`)
11. `update-database`
12. SQL server managment studio, use db name `{name}.database.windows.net`
13. `add-migration`, `update-database` for new class

## Photos in SQL/Azure

- use `byte[]` bytearray (can hold more than just images)
- Create Photo Upload!
    1. add `enctype="multipart/form-data` to `<form>` in `Create` view
    2. `<input type="file" id="Photo" name="Photo"/>` multiple if many 
       -  change validation for "Photo" in tag below too
    3. In Create IAction result, take "Photo" out of the Bind()
       - instead add `IFormFile Photo` (name var same as id in view) as second parameter to Action
        ``` 
        // check photo length isn't null and length > 0 and if so

       var memoryStream = new MemoryStream()
       await Photo.CopyToAsync(memoryStream)
       student.Photo = memoryStream.array

       _context.Add(student);
       async _context.SaveChangeAsync();
       return RedirectToAction(nameof(Index));
       ```
    4. in Controller Index view
        ```
        // not ideal way, write in page
        var base64 = Convert.ToBase64String(item.Photo)
        var imgSrc = String.Format("data:image/jpg;base64,{0}, base64)
        <img src=@imgSrc ...>
        ```
        or
        
        ```
        // ideal way, pull from database

        <img width="100" height="100" src="@Url.Action("GetStudentPhoto", "Students", new{item.Id})">

        // ... add action w param id

        var student = await _context.Student(FirstOrDefaultAsync(m => m.Id == id))
        if(student == null) return NotFound()
        var iamgeData = student.Photo
        return File(imageData, "image/jpg")
        ```

## Tweets
  - install `tweetinvi` and `vader2` or whatever
  - register for twitter dev account and ***save those keys*** because they can't be regenerated
  - create viewModel for details page
    - `List<TweetsClassWeWillCreate> studentTweets {get; set;}`
  - create Tweets class with string (text of tweet) and double (sentiment of tweet)
  - return ViewModel in Index and fix the view
  - 
    ```
    var tweets = response.Tweets;
    var analyzer = new SentimentIntensityAnalyzer();
    foreach(var tweetText in tweets)
    {
        var tweet = new StudentTweets();
        tweet.TweetText = tweetText.Text
        var results = analyzer.PolarityScores(tweet.TweetText);
        tweet.Sentiment = results.Compound;
        // add to VM
    }
    ```
   - display tweets
      - can calculate average in view model `AverageTweetSentiment()`
