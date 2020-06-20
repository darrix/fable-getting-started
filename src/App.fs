module App

open Browser.Dom

let increase = document.getElementById "increase"
let decrease = document.getElementById "decrease"
let countViewer = document.getElementById "countViewer"

let mutable currentCount = 0

let rnd = System.Random()

// add event handlers
increase.onclick <- fun ev -> currentCount <- currentCount + rnd.Next(5, 10)
                              countViewer.innerText <- sprintf "Count is %d" currentCount

decrease.onclick <- fun ev -> currentCount <- currentCount - rnd.Next(5, 10)
                              countViewer.innerText <- sprintf "Count is %d" currentCount 


// initializing the countViewer to start off
countViewer.innerText <- sprintf "Count is %d" currentCount

