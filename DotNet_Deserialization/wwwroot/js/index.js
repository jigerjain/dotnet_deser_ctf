function sendJSON() {

	let name = document.querySelector('#name');
	let email = document.querySelector('#email');
	let comments = document.querySelector('#comments');

	// Creating a XHR object 

	let xhr = new XMLHttpRequest();
	let url = "/Feedback/insecure";

	// open a connection

	xhr.open("POST", url, true);

	// Set the request header i.e. which type of content you are sending 
	xhr.setRequestHeader("Content-Type", "application/json");

	// Create a state change callback

	xhr.onreadystatechange = function () {
		if (xhr.readyState === 4 && xhr.status === 200) {

			// Print received data from server 
			alert("Feedback Submitted");
			location.reload();

		}
	};

	// Converting JSON data to string

	var data = JSON.stringify({ "name": name.value, "email": email.value, "comments": comments.value });

	// Sending data with the request 
	xhr.send(data);
} 
