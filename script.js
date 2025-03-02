document.addEventListener("DOMContentLoaded", function () {
    const loginForm = document.getElementById("loginForm");
    if (loginForm) {
        loginForm.addEventListener("submit", function (e) {
            e.preventDefault();
            let username = document.getElementById("username").value;
            let password = document.getElementById("password").value;

            fetch("../backend/login.php", {
                method: "POST",
                headers: { "Content-Type": "application/x-www-form-urlencoded" },
                body: `username=${username}&password=${password}`
            })
            .then(response => response.text())
            .then(data => {
                if (data.trim() === "success") {
                    window.location.href = "dashboard.html";
                } else {
                    document.getElementById("error-message").innerText = "Invalid login!";
                }
            });
        });
    }
});
