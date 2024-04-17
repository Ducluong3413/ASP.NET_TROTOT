
console.log("helooooo");

// Đăng nhập và đăng ký
document.addEventListener("DOMContentLoaded", function () {
    var loginLink = document.getElementById('login');
    var registerLink = document.querySelector('.register');
    var loginModal = document.getElementById('loginModal');
    var registerModal = document.getElementById('registerModal');

    loginLink.addEventListener('click', function () {
        registerModal.style.display = 'none';
        loginModal.style.display = 'block';
        console.log("login");

    });

    var loginCloseButton = document.querySelector('#loginModal .close');
    loginCloseButton.addEventListener('click', function () {
        console.log("close");
        loginModal.style.display = 'none';
    });

    registerLink.addEventListener('click', function () {
        loginModal.style.display = 'none';
        registerModal.style.display = 'block';
        console.log("dangki");

    });

    var registerCloseButton = document.querySelector('#registerModal .close');
    registerCloseButton.addEventListener('click', function () {
        registerModal.style.display = 'none';
    });

    var registerNewAccountLink = document.querySelector('#loginModal .body-no-have-account a');
    registerNewAccountLink.addEventListener('click', function (event) {
        event.preventDefault(); // Ngăn chặn hành vi mặc định của liên kết
        loginModal.style.display = 'none';
        registerModal.style.display = 'block';
    });
});
