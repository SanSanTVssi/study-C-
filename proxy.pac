function FindProxyForURL(url, host) {
    host = host.toLowerCase();
    url = url.toLowerCase();

    // always direct to gateway ip
    if (isInNet(host, "10.201.0.1", "255.255.255.255")) {
        return "DIRECT";
    }

    let resolvedHost = dnsResolve(host);
    if (!resolvedHost) {
        return "PROXY 10.201.0.1:3128";
    }

    // If the protocol is FTP, send direct.
    if (url.substring(0, 4) == "ftp:") {
        return "DIRECT";
    }

    // Redirect google.com to 2ip.ua
    if (host === "google.com") {
        return "PROXY 2ip.ua:80";
    }

    return "PROXY 10.201.0.1:3128";
}
