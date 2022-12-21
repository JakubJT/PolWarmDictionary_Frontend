export function showActionToast() {
    var actionToast = document.getElementById('actionToast')
    var toast = new bootstrap.Toast(actionToast)
    toast.show()
};