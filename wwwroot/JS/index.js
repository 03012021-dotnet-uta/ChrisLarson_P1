console.log('js works');

let username = document.querySelector("input[id='username']");
let password = document.querySelector("input[id='userpassword']");
//fetch to somewhere

//CustomerInfo.html
let fname = document.querySelector("input[id='getFirstName']");
let lname = document.querySelector("input[id='getLastName']");
let staddress = document.querySelector("input[id='getStreetAddress']");
let city = document.querySelector("input[id='getCity']");
let state = document.querySelector("input[id='getState']");
let zipcode = document.querySelector("input[id='getZipcode']");
const customerSubmit = document.querySelector("input[id='customerSubmit']")
function test(){
    console.log(String(fname.value));
    console.log(lname.value);
    console.log(staddress.value);
    console.log(city.value);
    console.log(state.value);
    console.log(zipcode.value);
}
customerSubmit.addEventListener("click",test)



//OrderHistory.html
let customergreeter = document.querySelector("greetCustomer");
function CustomGreeter(){
    customergreeter.innerHTML += (` ${fname.value} ${lname.value}!`);
}