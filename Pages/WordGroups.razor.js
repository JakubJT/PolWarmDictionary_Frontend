var theModal;

export function showActionToast() {
    var actionToast = document.getElementById('actionToast')
    var toast = new bootstrap.Toast(actionToast)
    toast.show()
};

export function showModal() {
    var modal = new bootstrap.Modal(document.getElementById('createCollectionModal'));
    modal.show();
    theModal = modal;
};

export function hideModal() {
    theModal.hide();
};