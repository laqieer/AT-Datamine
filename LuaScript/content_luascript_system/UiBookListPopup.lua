
-- 本貸出(タブ付き)制御オブジェクト
function book_list_with_tab()
    local book_list = system.InitializeBookListWithTab()
	book_list.Load()
	while book_list.IsProccessing() do
	    coroutine.yield()
	end
	return book_list
end

-- 読書本一覧
function book_list()
    local book_list = system.InitializeBookList()
	book_list.Load()
	while book_list.IsProccessing() do
	    coroutine.yield()
	end
	return book_list
end

-- 本情報ポップアップ
function load_book_popup()
    local popup = system.InitializeBookPopup()
    popup.Load()
    while popup.IsProccessing() do
	    coroutine.yield()
    end
    return popup
end

-- 本返却ポップアップ
function load_book_return_popup()
    local popup = system.InitializeBookReturnPopup()
    popup.Load()
    while popup.IsProccessing() do
	    coroutine.yield()
    end
    return popup
end