--[[
	キャラクター専用の処理
]]

-- 口パク制御用のグローバル変数。message_base()で参照される
LipSyncFixedFlag = false

-- キャラクターの回転
--  character = コントローラID
--  angY = 到着角度Y
--  duration = かかる秒数
-- return 通知ID
function turn_chara(character, angY, duration)
	if type(angY) == "table" then
		return character.Rotate( 0.0, angY[1], 0.0, angY[2], false)
	else
		return character.Rotate( 0.0, angY, 0.0, duration, false)
	end
end

-- キャラクターの表情変更
--  character = コントローラID
--  facialTag = 表情タグ
function change_face(character, facialTag)
	character.PlayFacial(facialTag, 0.5, 1.0, false)
end

-- キャラクターの目パチ動作を強制的に固定する
-- character = コントローラーID
-- syncTag 開き固定"Open", 閉じ固定"Close", 自動制御"Auto"
function force_eyesync(character, syncTag) 
	character.ForceEyeSync(syncTag)
end

-- キャラクターの口パク動作を強制的に固定する
-- character = コントローラーID
-- syncTag 開き固定"Open1", 開き固定のモーション違い"Open2", 閉じ固定"Close1", 閉じ固定のモーション違い"Close2", 自動制御"Auto"
function force_lipsync(character, syncTag) 
	character.ForceLipSync(syncTag)
end

-- 目パチ固定の予約　表情変更後に適用される
-- 引数はforce_eyesyncと同じ
function reserve_eyesync(character, syncTag)
	character.ReserveEyeSync(syncTag)
end

-- 口パク固定の予約　表情変更後に適用される
-- 引数はforce_lipsyncと同じ
function reserve_lipsync(character, syncTag)
	character.ReserveLipSync(syncTag)
end

-- キャラクターの口パクの状態の指定
--  character = コントローラID
--  lipsyncTag = 状態名
function lipsync(character, lipsyncTag)
	if lipsyncTag == "FixedClose" then
		LipSyncFixedFlag = true
		character.SetLipSync("Close")
	else
		character.SetLipSync(lipsyncTag)
	end
end

-- 口パク判定用の文字列設定
--  character = コントローラID
--  text = 発言セリフ
function set_lipsync_text(character, text,time)
	character.SetLipSyncText(text,time)
end

-- 口パクスクリプトのアクティブを切り替える
--  character = コントローラID
--  flag = on off
function set_is_active_lipsync(character, flag)
	character.SetIsActiveLipSync(flag)
end

-- キャラクター画像を登録する。エンジニアの内部ロジック専用
function character2D_Internal(character, tagBase, faceAssetbundleName, facePrefabName, thumAssetbundleName, thumbImageName, fullAssetbundleName, fullImageName, hiresAssetbundleName, hiresImageName, styleId)
	local function load_prefab(tag, assetbundleName, fileName)
		if fileName != nil then
			local signal = system.LoadStackObject(tag, assetbundleName, fileName)
			while signal.IsProccessing() do
				coroutine.yield()
			end
			return tag
		else
			return nil
		end
	end
	local function load_image_local(tag, assetbundleName, fileName)
		if fileName != nil then
			local signal = system.LoadStackImage(tag, assetbundleName, fileName)
			while signal.IsProccessing() do
				coroutine.yield()
			end
			return tag
		else
			return nil
		end
	end

	if faceAssetbundleName != nil and facePrefabName != nil then 
		character.FaceImageTag = load_prefab(tagBase .. "_face", faceAssetbundleName, facePrefabName)
	end
	if thumAssetbundleName != nil and thumbImageName != nil then 
		character.ThumbImageTag = load_image_local(tagBase .. "_thumb", thumAssetbundleName, thumbImageName)
	end
	if fullAssetbundleName != nil and fullImageName != nil then 
		character.FullImageTag = load_image_local(tagBase .. "_full", fullAssetbundleName, fullImageName)
	end
	if hiresAssetbundleName != nil and hiresImageName != nil then 
		character.HiResImageTag = load_image_local(tagBase .. "_hires", hiresAssetbundleName, hiresImageName)
	end

	local signal = system.LoadIllustLayoutInfo(character, styleId)
	while signal.IsProccessing() do
		coroutine.yield()
	end

	character.StyleId = styleId

end

-- キャラクター画像を登録する（不要な箇所はnilで）
--  character = コントローラID
--  tagBase = 画像管理用のタグ
--  assetbundleName = 画像のアセットバンドル名
--  facePrefabName = 顔画像のプレハブの名前
--  cutPrefabName = カットイン画像のプレハブの名前
--  thumbImageName = UI画像の名前
--  fullImageName = UI画像の名前
--  hiresImageName = UI画像の名前
function character2D(character, tagBase, assetbundleName, facePrefabName, cutPrefabName, thumbImageName, fullImageName, hiresImageName)
	local function load_prefab(tag, assetbundleName, fileName)
		if fileName != nil then
			local signal = system.LoadStackObject(tag, assetbundleName, fileName)
			while signal.IsProccessing() do
				coroutine.yield()
			end
			return tag
		else
			return nil
		end
	end
	local function load_image_local(tag, assetbundleName, fileName)
		if fileName != nil then
			local signal = system.LoadStackImage(tag, assetbundleName, fileName)
			while signal.IsProccessing() do
				coroutine.yield()
			end
			return tag
		else
			return nil
		end
	end
	if facePrefabName != nil then 
		character.FaceImageTag = load_prefab(tagBase .. "_face", assetbundleName, facePrefabName)
	end
	if cutPrefabName != nil then 
		character.CutinImageTag = load_prefab(tagBase .. "_cutin", assetbundleName, cutPrefabName)
	end
	if thumbImageName != nil then 
		character.ThumbImageTag = load_image_local(tagBase .. "_thumb", assetbundleName, thumbImageName)
	end
	if fullImageName != nil then 
		character.FullImageTag = load_image_local(tagBase .. "_full", assetbundleName, fullImageName)
	end
	if hiresImageName != nil then 
		character.HiResImageTag = load_image_local(tagBase .. "_hires", assetbundleName, hiresImageName)
	end
end

-- キャラクターの特定部分の位置取得
--  character = コントローラID
--  boneName = ボーンの名前
-- return 位置情報テーブル [1]:X座標, [2]:Y座標, [3]:Z座標
function get_bone_position(character, boneName)
	return character.GetBonePosition(boneName)
end

--weightのデフォルト値
local lookAtWeight = {0.4, 0.08, 0.7, 0.6}

-- キャラクターの注視パラメータの設定
--  character = コントローラID
--  weight = 反映係数（0.0～1.0）
--  body = 胴体部分の影響係数（0.0～1.0）
--  head = 頭部分の影響係数（0.0～1.0）
--  clamp = モーションへの影響係数（0.0～1.0）
function lookat_weight(character, weight, body, head, clamp)
	if type(weight) == "table" then
		character.SetLookAtWeight(weight[1], weight[2], weight[3], weight[4])
	else
		character.SetLookAtWeight(weight, body, head, clamp)
	end
end

-- キャラクターの注視パラメータの設定
--  character = コントローラID
function lookat_weight_default(character)
	character.SetLookAtWeight(lookAtWeight[1],lookAtWeight[2],lookAtWeight[3],lookAtWeight[4])
end

-- キャラクターの注視パラメータの設定
--  character = コントローラID
function lookat_weight_reset(character)
	character.SetLookAtWeightReset()
end

-- キャラクターの注視パラメータの設定(モーション補間を行う
--  character = コントローラID
--  weight = 反映係数（0.0～1.0）
--  body = 胴体部分の影響係数（0.0～1.0）
--  head = 頭部分の影響係数（0.0～1.0）
--  clamp = モーションへの影響係数（0.0～1.0）
--  speed = 振り向き速度倍率
function lookat_delay_weight(character, weight, body, head, clamp , speed)
	if type(weight) == "table" then
		character.SetLookAtDelayWeight(weight[1], weight[2], weight[3], weight[4], body)
	else
		character.SetLookAtDelayWeight(weight, body, head, clamp, speed)
	end
end

-- キャラクターの注視パラメータの設定(speedの時間をかけて注視する
--  character = コントローラID
--  speed = 振り向き速度倍率
function lookat_delay_weight_default(character, speed)
	character.SetLookAtDelayWeight(lookAtWeight[1],lookAtWeight[2],lookAtWeight[3],lookAtWeight[4], speed)
end

-- キャラクターの注視パラメータの設定
--  character = コントローラID
--  speed = 振り向き速度の倍率
function lookat_delay_weight_reset(character,speed)
	character.SetLookAtDelayWeightReset(speed)
end

-- キャラクターの注視位置の指定
--  character = コントローラID
--  posTable = 位置情報テーブル [1]:X座標, [2]:Y座標, [3]:Z座標
function lookat_position(character, posTable)
	character.SetLookAtPosition(posTable[1], posTable[2], posTable[3])
end

-- キャラクターに設定された注視位置から指定座標分ずらして注視する
--  character = コントローラID
--  x = x座標
--  y = y座標
--  z = z座標
function set_lookat_offset(character,x,y,z)
	if type(x) == "table" then
		character.SetLookAtOffset(x[1],x[2],x[3])
	else
		character.SetLookAtOffset(x,y,z)
	end
end

-- キャラクターの特定位置に表示するエフェクトを設定
--  character = コントローラID
--  boneName = 出現させる場所のボーンの名前
--  effect = 表示させたいオブジェクト
--  offsetX = 表示位置の調整値X
--  offsetY = 表示位置の調整値Y
--  offsetZ = 表示位置の調整値Z
function effect_at_character(character, boneName, effect, offsetX, offsetY, offsetZ)
	local emotion_position = get_bone_position(character, boneName)
	if type(offsetX) == "table" then
		slidemove(effect, emotion_position[1] + offsetX[1], emotion_position[2] + offsetX[2], emotion_position[3] + offsetX[3], 0.0)
	else
		slidemove(effect, emotion_position[1] + offsetX, emotion_position[2] + offsetY, emotion_position[3] + offsetZ, 0.0)
	end
	effect.SetActive(true)
end

-- 表情・目パチ・口パクの操作を有効にするか　※デフォルトは有効
--  character = コントローラID
--  is_valid = true:change_face()やlipsync()等が有効
--             false:アニメーションで表情や目パチ、口パクを操作する
function set_active_facial_control(character, is_valid)
	character.SetActiveFacialControl(is_valid)
end

-- キャラクターの目の機能を追加
--  character = コントローラID
--  centerX = 視線の基準位置（レンダラーのルートボーンからのローカル座標）X
--  centerY = 視線の基準位置（レンダラーのルートボーンからのローカル座標）Y
--  centerZ = 視線の基準位置（レンダラーのルートボーンからのローカル座標）Z
--  directionX = 視線の正面の向き（レンダラーのルートボーンからのローカル向き）X
--  directionY = 視線の正面の向き（レンダラーのルートボーンからのローカル向き）Y
--  directionZ = 視線の正面の向き（レンダラーのルートボーンからのローカル向き）Z
--  minAngleV = 視線の縦角度の最小値
--  maxAngleV = 視線の縦角度の最大値
--  minAngleH = 視線の横角度の最小値
--  maxAngleH = 視線の横角度の最大値
--  convertL = 視線の角度から値に変換する際の変換係数（左）
--  convertR = 視線の角度から値に変換する際の変換係数（右）
--  convertU = 視線の角度から値に変換する際の変換係数（上）
--  convertD = 視線の角度から値に変換する際の変換係数（下）
function add_eye_control(character, centerX, centerY, centerZ, directionX, directionY, directionZ, minAngleV, maxAngleV, minAngleH, maxAngleH, convertL, convertR, convertU, convertD)
	if type(centerX) == "table" then
		character.AddEyeControl("Geo_Eyes", centerX[1], centerX[2], centerX[3], centerX[4], centerX[5], centerX[6], centerX[7], centerX[8], centerX[9], centerX[10], centerX[11], centerX[12], centerX[13], centerX[14])
	else
		character.AddEyeControl("Geo_Eyes", centerX, centerY, centerZ, directionX, directionY, directionZ, minAngleV, maxAngleV, minAngleH, maxAngleH, convertL, convertR, convertU, convertD)
	end
end

-- キャラクターの目のハイライト設定の登録
--  character = コントローラID
--  scale = ハイライトの大きさ（0.0～1.0）
--  speed = ハイライトのキラキラの速度（0より上、無効化は0.0）
function set_eye_hilight(character, scale, speed)
	character.SetEyeHilight(scale, speed)
end

-- キャラクターの目のスケールの登録
--  character = コントローラID
--  eye = 瞳の大きさ（0.0～1.0）
--  pupils = 瞳孔の大きさ（0.0～1.0）
function set_eye_scale(character, eye, pupils)
	character.SetEyeScale(eye, pupils)
end

-- キャラクターの目の注視対象を登録
--  character = コントローラID
--  target = 注視対象のコントローラID　※注視設定を外すならnilか省略
--  partsName = 注視対象のモデル内のオブジェクト名　※ルートを対象にするならnilか省略
function set_eye_lookat(character, target, partsName)
	character.SetLookat(target, partsName)
end

-- キャラクターの目の角度を登録
--  character = コントローラID
--  angleV = 目の縦の角度
--  angleH = 目の横の角度
function set_eye_angle(character, angleV, angleH)
	if type(angleV) == "table" then
		character.SetLookAngle(angleV[2], angleV[1])
	else
		character.SetLookAngle(angleH, angleV)
	end
end

-- オブジェクトの首と胴体をターゲットに向き続けるように指定。
--  object = コントローラID
--  target = 向き続ける対象のコントローラID
--  partsObjectName = 対象のオブジェクト名
function keep_ik_lookat(object, target, partsObjectName)
	object.KeepIkLookAt(target, partsObjectName)
	if not object.GetIsSetWeight() then
		lookat_weight_default(object)
	end
	
end

-- オブジェクトの首と胴体をターゲットにモーション補間をかけながら向く
--  object = コントローラID
--  target = 向き続ける対象のコントローラID
--  partsObjectName = 対象のオブジェクト名
--  speed = 振り向き速度倍率
function keep_delay_ik_lookat(object, target, partsObjectName, speed)
	if not object.GetIsSetWeight() then
		object.KeepIkLookAt(target, partsObjectName)
		lookat_delay_weight_default(object,speed)
	else
		object.KeepDelayIkLookAt(target, partsObjectName, speed)
	end
	
end

-- オブジェクトの首と胴体をターゲットに向き続けるように指定。
--  object = コントローラID
--  parent = 親オブジェクト(nilで省略も可
--  objectName = 対象のオブジェクト名
function keep_ik_lookat_object(object, parent, objectName)
	object.KeepIkLookAtObject(parent, objectName)
	if not object.GetIsSetWeight() then
		lookat_weight_default(object)
	end
end

-- オブジェクトの首と胴体をターゲットにモーション補間をかけながら向く
--  object = コントローラID
--  parent = 親オブジェクト(nilで省略も可
--  objectName = 対象のオブジェクト名
--  speed = 振り向き速度倍率
function keep_delay_ik_lookat_object(object, target, objectName, speed)
	if not object.GetIsSetWeight() then
		object.KeepIkLookAtObject(parent, objectName)
		lookat_delay_weight_default(object,speed)
		
	else
		object.KeepDelayIkLookAtObject(parent, objectName, speed)
	end
	
end

-- 自動で話者を向く処理の有効無効を切り替える
--  object = コントローラID
--  enable = true: 有効 false: 無効
function set_enable_auto_lookat(object, enable)
	object.SetEnableAutoLookAt(enable)
end

-- 全キャラの自動で話者を向く処理の有効無効を切り替える
--  enable = true: 有効 false: 無効
function set_enable_auto_lookat_all(enable)
	local humanList = GetHumanList()
	for i,human in ipairs(humanList) do
		set_enable_auto_lookat(human, enable)
	end
end

-- キャラにおけるディフォルトスタイルを使用して2Dを構築
--  character = コントローラID
--  tagBase = 画像管理用のタグ
--  characterId = characterのID
function character2DDefaultStyleFull(character, tagBase, characterId )
	
	local faceAssetbundleName = system.ResouceDataUtility.GetFaceImageAssetBundleNameByCharaterId(characterId)
	local facePrefabName = system.ResouceDataUtility.GetFaceImageAssetNameByCharaterId(characterId)
	
	local thumAssetbundleName = system.ResouceDataUtility.GetThumbnailAssetbundleNameByCharacterId(characterId)
	local thumbImageName = system.ResouceDataUtility.GetThumbnailAssetNameByCharacterId(characterId)
	
	local fullAssetbundleName = system.ResouceDataUtility.GetFullImageAssetBundleNameByCharacterId(characterId)
	local fullImageName = system.ResouceDataUtility.GetFullImageAssetNameByCharacterId(characterId)

	local hiresAssetbundleName = system.ResouceDataUtility.GetHiResImageAssetBundleNamByCharacterId(characterId)
	local hiresImageName = system.ResouceDataUtility.GetHiResImageAssetNameByCharacterId(characterId)

	local styleId = system.ResouceDataUtility.GetDefaultStyleIDByCharacterId(characterId)

	character2D_Internal(character, tagBase, faceAssetbundleName, facePrefabName, thumAssetbundleName, thumbImageName, fullAssetbundleName, fullImageName, hiresAssetbundleName, hiresImageName, styleId)
	
end

function character2DDefaultStyleFull_Preload(character, tagBase, characterId)
	system.PreLoadRequest(system.ResouceDataUtility.GetFaceImageAssetBundleNameByCharaterId(characterId))
	system.PreLoadRequest(system.ResouceDataUtility.GetThumbnailAssetbundleNameByCharacterId(characterId))
	system.PreLoadRequest(system.ResouceDataUtility.GetFullImageAssetBundleNameByCharacterId(characterId))
	system.PreLoadRequest(system.ResouceDataUtility.GetHiResImageAssetBundleNamByCharacterId(characterId))
end

-- スタイルを使用して2Dを構築
--  character = コントローラID
--  tagBase = 画像管理用のタグ
--  styleId = styleのID
function character2DFull(character, tagBase, styleId )

	local faceAssetbundleName = system.ResouceDataUtility.GetFaceImageAssetBundleNameByStyleId(styleId)
	local facePrefabName = system.ResouceDataUtility.GetFaceImageAssetNameByStyleId(styleId)
	
	local thumAssetbundleName = system.ResouceDataUtility.GetThumbnailAssetbundleNameByStyleId(styleId)
	local thumbImageName = system.ResouceDataUtility.GetThumbnailAssetNameByStyleId(styleId)
	
	local fullAssetbundleName = system.ResouceDataUtility.GetFullImageAssetBundleNameByStyleId(styleId)
	local fullImageName = system.ResouceDataUtility.GetFullImageAssetNameByStyleId(styleId)
	
	local hiresAssetbundleName = system.ResouceDataUtility.GetHiResImageAssetBundleNameByStyleId(styleId)
	local hiresImageName = system.ResouceDataUtility.GetHiResImageAssetNameByStyleId(styleId)

	character2D_Internal(character, tagBase, faceAssetbundleName, facePrefabName, thumAssetbundleName, thumbImageName, fullAssetbundleName, fullImageName, hiresAssetbundleName, hiresImageName, styleId)
end

function character2DFull_Preload(character, tagBase, styleId)
	system.PreLoadRequest(system.ResouceDataUtility.GetFaceImageAssetBundleNameByStyleId(styleId))
	system.PreLoadRequest(system.ResouceDataUtility.GetThumbnailAssetbundleNameByStyleId(styleId))
	system.PreLoadRequest(system.ResouceDataUtility.GetFullImageAssetBundleNameByStyleId(styleId))
	system.PreLoadRequest(system.ResouceDataUtility.GetHiResImageAssetBundleNameByStyleId(styleId))
end

-- キャラにおけるディフォルトスタイルを使用して2Dを構築。基礎だけ
--  character = コントローラID
--  tagBase = 画像管理用のタグ
--  characterId = characterのID
function character2DDefaultStyleMinimum(character, tagBase, characterId )
	
	local faceAssetbundleName = system.ResouceDataUtility.GetFaceImageAssetBundleNameByCharaterId(characterId)
	local facePrefabName = system.ResouceDataUtility.GetFaceImageAssetNameByCharaterId(characterId)

	local thumAssetbundleName = system.ResouceDataUtility.GetThumbnailAssetbundleNameByCharacterId(characterId)
	local thumbImageName = system.ResouceDataUtility.GetThumbnailAssetNameByCharacterId(characterId)

	local fullAssetbundleName = nil
	local fullImageName = nil

	local hiresAssetbundleName = nil
	local hiresImageName = nil

	local styleId = system.ResouceDataUtility.GetDefaultStyleIDByCharacterId(characterId)

	character2D_Internal(character, tagBase, faceAssetbundleName, facePrefabName, thumAssetbundleName, thumbImageName, fullAssetbundleName, fullImageName, hiresAssetbundleName, hiresImageName, styleId)
end

function character2DDefaultStyleMinimum_Preload(character, tagBase, styleId)
	system.PreLoadRequest(system.ResouceDataUtility.GetFaceImageAssetBundleNameByCharaterId(characterId))
	system.PreLoadRequest(system.ResouceDataUtility.GetThumbnailAssetbundleNameByCharacterId(characterId))
end

-- キャラにおけるスタイルを使用して2Dを構築。基礎だけ
--  character = コントローラID
--  tagBase = 画像管理用のタグ
--  styleId = styleのID
function character2DMinimum(character, tagBase, styleId )
	
	local faceAssetbundleName = system.ResouceDataUtility.GetFaceImageAssetBundleNameByStyleId(styleId)
	local facePrefabName = system.ResouceDataUtility.GetFaceImageAssetNameByStyleId(styleId)

	local thumAssetbundleName = system.ResouceDataUtility.GetThumbnailAssetbundleNameByStyleId(styleId)
	local thumbImageName = system.ResouceDataUtility.GetThumbnailAssetNameByStyleId(styleId)

	local fullAssetbundleName = nil
	local fullImageName = nil

	local hiresAssetbundleName = nil
	local hiresImageName = nil

	character2D_Internal(character, tagBase, faceAssetbundleName, facePrefabName, thumAssetbundleName, thumbImageName, fullAssetbundleName, fullImageName, hiresAssetbundleName, hiresImageName, styleId)

end

function character2DMinimum_Preload(character, tagBase, styleId)
	system.PreLoadRequest(system.ResouceDataUtility.GetFaceImageAssetBundleNameByStyleId(styleId))
	system.PreLoadRequest(system.ResouceDataUtility.GetThumbnailAssetbundleNameByStyleId(styleId))
end
