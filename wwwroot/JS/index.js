console.log('js works');

let username = LoginPage.querySelector("input[id='username']");
let password = LoginPage.querySelector("input[id='userpassword']");
loginForm.addEvetListener('submit', (event) => {
    event.preventDefault();
    const loginData = {
        Fname: loginForm.fname.value.trim(),
        Lname: loginForm.lname.value.trim()
    }
    fetch('api/meme', {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type':'application/json'
        },
        body:JSON.stringify(loginData)
    }).then(response => {
        if (!response.ok) {
            throw new Error(`Network response was not ok (${response.status})`);
        } else return response.json();
    }).then((jsonResponse) => {
        responseDiv[0].textContent = jsonResponse.fname + ' ' + jsonResponse.lname;
        console.log(jsonResponse);
    }).catch(function(err) {
        console.log('Failed to fetch page: ', err);
    });
});

//CustomerInfo.html
let fname = CustomerInfo.querySelector("input[id='getFirstName']");
let lname = CustomerInfo.querySelector("input[id='getLastName']");
let staddress = CustomerInfo.querySelector("input[id='getStreetAddress']");
let city = CustomerInfo.querySelector("input[id='getCity']");
let state = CustomerInfo.querySelector("input[id='getState']");
let zipcode = CustomerInfo.querySelector("input[id='getZipcode']");
const customerSubmit = CustomerInfo.querySelector("input[id='customerSubmit']")
function test(){
    console.log(String(fname.value));
    console.log(lname.value);
    console.log(staddress.value);
    console.log(city.value);
    console.log(state.value);
    console.log(zipcode.value);
}
customerSubmit.addEventListener("click",test)



