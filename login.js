document.addEventListener("DOMContentLoaded", function () {
    document.getElementById("loginForm").addEventListener("submit", function(event) {
        event.preventDefault(); // Prevent page refresh

        const username = document.getElementById("username").value;
        const password = document.getElementById("password").value;
        const loginMessage = document.getElementById("loginMessage");

        // Fixed admin credentials
        if (username === "Admin" && password === "Admin123") {
            localStorage.setItem("adminLoggedIn", "true"); // Save login state
            window.location.href = "dashboard.html"; // Redirect to dashboard
        } else {
            loginMessage.textContent = "Invalid username or password.";
            loginMessage.style.color = "red";
        }
    });
});
