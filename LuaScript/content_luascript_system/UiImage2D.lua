
Image_2DBackCanvas = system.LoadUIToBack("ui_page_adv", "Container_Image2D", 100)
Image_2DCanvas = system.LoadUIToRootCanvas("ui_page_adv", "Container_Image2D", 100)
UiLoadList[#UiLoadList + 1] = Image_2DBackCanvas
UiLoadList[#UiLoadList + 1] = Image_2DCanvas

--  画像を読み込む
--  tag = 表示する時に使うタグ名。画像管理にも使われる
--  assetbundleName = 画像のアセットバンドル名
--  fileName = 画像のファイル名
function load_image(tag, assetbundleName, fileName)
	local signal = system.LoadStackImage(tag, assetbundleName, fileName)
	while signal.IsProccessing() do
		coroutine.yield()
	end
end

function load_image_preload(tag, assetbundleName, fileName)
	system.PreLoadRequest(assetbundleName)
end

-- 画像を表示する
-- tag = 画像を読み込んだ時に指定したタグ名
-- offsetX = X座標:画面サイズに対する中央からの比率
-- offsetY = Y座標:画面サイズに対する中央からの比率
-- fadeIn = フェード時間。0で瞬間表示
-- set2dCanvas = trueのとき2DCanvas上のイメージオブジェクトに対して操作する
function show_image(tag, offsetX, offsetY, fadeIn, showMask, showBg, set2dCanvas)
	local target = Image_2DBackCanvas
	if set2dCanvas != nil and set2dCanvas then
		target = Image_2DCanvas
	end
	if fadeIn == nil then
		fadeIn = 0.0
	end
	if showMask == nil then
		showMask = true
	end
	if showBg == nil then
		showBg = true
	end
	target.SetOnImage2D(tag, offsetX, offsetY)
	target.SetMaskImage2D(showMask)
	target.SetActive("BG", showBg)
	target.SetActive("CoverFrame", showMask)
	target.SetFadeDuration("Canvas", "Show", fadeIn)
	target.SetFadeDuration("BG", "Show", fadeIn)
	return target.Play("Show", true)
end

-- 画像を非表示にする
-- fadeOut = フェード時間。0で瞬間非表示
-- set2dCanvas = trueのとき2DCanvas上のイメージオブジェクトに対して操作する
function hide_image(fadeOut, set2dCanvas)
	local target = Image_2DBackCanvas
	if set2dCanvas != nil and set2dCanvas then
		target = Image_2DCanvas
	end
	if fadeOut == nil then
		fadeOut = 0.0
	end
	target.SetFadeDuration("Canvas", "Hide", fadeOut)
	return target.Play("Hide", false)
end

-- 画像の下地に表示を切り替える
-- showBg = 表示するか
-- set2dCanvas = trueのとき2DCanvas上のイメージオブジェクトに対して操作する
function show_image_bg(showBg, set2dCanvas)
	local target = Image_2DBackCanvas
	if set2dCanvas != nil and set2dCanvas then
		target = Image_2DCanvas
	end
	target.SetActive("BG", showBg)
end

-- 画像のマスク状態を切り替える
-- showMask = マスクするか
-- set2dCanvas = trueのとき2DCanvas上のイメージオブジェクトに対して操作する
function show_image_mask(showMask, set2dCanvas)
	local target = Image_2DBackCanvas
	if set2dCanvas != nil and set2dCanvas then
		target = Image_2DCanvas
	end
	target.SetMaskImage2D(showMask)
end

-- 画像の位置を変更する
-- x = x位置(幅1334で中心から左が-右が+)
-- y = y位置(高さ750で中心から下が-上が+)
-- set2dCanvas = trueのとき2DCanvas上のイメージオブジェクトに対して操作する
function set_position_image(x, y, set2dCanvas)
	local target = Image_2DBackCanvas
	if set2dCanvas != nil and set2dCanvas then
		target = Image_2DCanvas
	end
	target.SetImagePosition(x, y)
end

-- 画像を移動させる
-- x = x位置(幅1334で中心から左が-右が+)
-- y = y位置(高さ750で中心から下が-上が+)
-- duration = 移動時間
-- method = Linear, EaseIn, EaseOut, EaseInOutを指定可能
-- set2dCanvas = trueのとき2DCanvas上のイメージオブジェクトに対して操作する
function move_to_image(x, y, duration, method, set2dCanvas)
	local target = Image_2DBackCanvas
	if set2dCanvas != nil and set2dCanvas then
		target = Image_2DCanvas
	end
	return target.ImageMoveTo(x, y, duration, method)
end

-- 画像のスケールを設定する
-- x = xスケール。1が等倍
-- y = yスケール。1が等倍
-- set2dCanvas = trueのとき2DCanvas上のイメージオブジェクトに対して操作する
function set_scale_image(x, y, set2dCanvas)
	local target = Image_2DBackCanvas
	if set2dCanvas != nil and set2dCanvas then
		target = Image_2DCanvas
	end
	target.SetImageScale(x, y)
end

-- 画像を拡縮させる
-- x = xスケール。1が等倍
-- y = yスケール。1が等倍
-- duration = 移動時間
-- method = Linear, EaseIn, EaseOut, EaseInOutを指定可能
-- set2dCanvas = trueのとき2DCanvas上のイメージオブジェクトに対して操作する
function scale_to_image(x, y, duration, method, set2dCanvas)
	local target = Image_2DBackCanvas
	if set2dCanvas != nil and set2dCanvas then
		target = Image_2DCanvas
	end
	return target.ImageScaleTo(x, y, duration, method)
end
