function FindProxyForURL(url, host) {

    // Redirect google.com to 2ip.ua
    if (host === "google.com") {
        return "PROXY 1.1.1.1";
    }

    return "PROXY 1.1.1.1";
}
