var cls = document.getElementById("products").getElementsByTagName("td");
var sum = 0;
for (var i = 0; i < cls.length; i++) {
if (cls[i].className == "price") {
        sum += isNaN(cls[i].innerHTML) ? 0 : parseInt(cls[i].innerHTML);
    }
}
var div = document.getElementById("total");
if (sum != 0) {
    div.style.backgroundColor = "lightblue";
}
div.innerHTML = sum;
