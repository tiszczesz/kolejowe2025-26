async function GetUsers() {
    const response = await fetch('http://localhost:5161/api/users/');
    const data = await response.json();
    console.log(data);
}

GetUsers();