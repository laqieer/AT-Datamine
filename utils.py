def read_bytes(binary_file, count):
    if count == 0:
        return b''
    s = binary_file.read(count)
    if len(s) < count:
        raise EOFError
    return s