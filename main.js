document.addEventListener("DOMContentLoaded", function() {
    if (document.getElementById("loginForm")) {
        document.getElementById("loginForm").addEventListener("submit", login);
    }
    if (document.getElementById("borrowForm")) {
        document.getElementById("borrowForm").addEventListener("submit", submitBorrowRequest);
    }
    if (document.getElementById("requestsTable")) {
        fetchRequests();
    }
});

function login(event) {
    event.preventDefault();
    let username = document.getElementById("username").value;
    let password = document.getElementById("password").value;

    fetch("../backend/login.php", {
        method: "POST",
        headers: { "Content-Type": "application/x-www-form-urlencoded" },
        body: `username=${username}&password=${password}`,
    })
    .then(response => response.text())
    .then(data => {
        if (data.trim() === "success") {
            window.location.href = "dashboard.html";
        } else {
            alert("Invalid credentials!");
        }
    });
}

function submitBorrowRequest(event) {
    event.preventDefault();
    let formData = new FormData(document.getElementById("borrowForm"));

    fetch("../backend/borrow.php", {
        method: "POST",
        body: formData
    })
    .then(response => response.text())
    .then(data => alert(data === "success" ? "Request Submitted!" : "Error!"));
}

function fetchRequests() {
    fetch("../backend/dashboard.php")
        .then(response => response.json())
        .then(data => console.log(data));
}

function logout() {
    fetch("../backend/logout.php").then(() => window.location.href = "login.html");
}
