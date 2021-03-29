//OrderHistory.html
window.addEventListener("load");
let fname;
let lname;
let customergreeter = document.querySelector("greetCustomer");
function CustomGreeter(){
    customergreeter.innerHTML += (` ${fname.value} ${lname.value}!`);
}
let thetable = document.querySelector("historyTable");

function AddItem(){
    thetable.innerHTML += `<tr>Store: ${store}</tr>`
    thetable.innerHTML += `<tr><td>${itemname} </td> <td>${cost}</td></tr>`
}