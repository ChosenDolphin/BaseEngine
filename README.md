# BaseEngine
This project has been an ordeal. I had some remnants of a game engine in java that I didn't finish.
Instead of finishing that, I chose to start from scratch in C# so I could get some experience.
Going into this project, I had only used C# in the unity engine, which I knew would be notably different.
Since I couldn't use Unity I needed to find another place to code the engine. My first instict was vim, because thats where I do most things and I like it.
After an unpleaent length of time, and confirmation from Andy, I found out that that would not be a viable option.
Next I tried VS Code, because that's the only multi-language IDE I've ever used.
After eventually getting C# set up for VS code I started making the engine. Part way through, I discovered that you can use C# in VS Coe, but it does not support its graphics.
This meant I had to use the whole Visual Studio which I haven't used for 6 years. Eventually, I set out on the right path.

I restarted the engine from scratch four times in VS. The first time was because I didn't know how to use windows forms and ended up confusing me.
I found *A* video online doing something similar to this, so I tried to get some guidance. He used a console application which made more sense to me, so I tried that out fr awhile.
Eventually I found out that they used forms anyway, so it ended up being more problematic than it need to.
At some point during the proccess Andy sent me a link to a video he made on YouTube, but when I eventually went to click on it, I found that it was privated.
Later on he fixed that and I took a look at what it was. At face value, it was exactly what I needed.
Using a compination of that video, simpleGame.js, and the C# documentation, I made some significant headway.

I just wanted to make something that worked, so I had planned on keeping it simple. I planned to have a car that I drew drive around and shoot bullets.
Everything was going fine until I tried to rotate the image. Come to find out, you cannot rotate a pictureBox.
You can however rotate whats inside it, but only to preset angles, which was no good. My solution was to use the graphics system to draw the car instead of using the pictureBox.
I would like to not that before diving into troubleshooting this, it did work. The car speed up or down, and turned accordingly. It's just that the image didn't.
For some reason, g.DrawImage() decided it wasn't going to draw the image, despite having the image and the point at which to draw it. 
In troubleshooting that, the picture/graphics/pictureBox had a critial falure, whic led me to my latest retart.

I had been basing my engine on the abstract ADT that we made in class, as Andy said building something like our basic design would be a good project.
Up until reset #4, I had everything in a single file, as I was just trying to get things working.
I have since made a seperate class for the sprite in hopes that DrawImage might play nice this time. So at this point, my engine is a little less advanced than what we made.
It also doesn't draw. I took off work today to try and sort this thing out, but to no avail.
I will be submiting what I have cobbled together, but I do plan on fixing this sob to get it to what I was planning. Even if I never use this engine again.
At first, C# was a huge pain, then it started to grow on me. Then I spentmost of a day just tring to spin a picture, which will of course end up being excedingly simple.
I'm not happy, but I'm not giving up.
