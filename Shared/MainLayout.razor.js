export function setCulture(value) {
    window.localStorage['Culture'] = value;
};

export function getCulture() {
    return window.localStorage['Culture'];
};
