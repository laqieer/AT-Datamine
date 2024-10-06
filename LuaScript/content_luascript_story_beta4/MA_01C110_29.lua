-- このluaスクリプトは、MA_01C110_29.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Worry")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…クラリスにあんなひどい怪我を<br>負わせたのがアーサーだなんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_290002")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんな…<br>いったいどうして、どうしてそんな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_290004")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:ガウェインが言ってただろ<br>あのヤロウにとって円卓の騎士は邪魔なんだよ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C110_290005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モルドレッド★★:円卓の騎士のキラーズもまた同様ってことだ<br>…なんでかは知らねえがな
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C110_290006")

	PlayAction(Actor004,"to  Std_Worry")

	--★★モルドレッド★★:アイツはオレたちを殺す気だった<br>なんで思いとどまったかは知らねぇが
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C110_290007")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★モルドレッド★★:…とにかく、あのヤロウはもう<br>甘ちゃんだった頃のアイツじゃねえってことだ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C110_290008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C110_290010","MA_01C110_290011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんな…そんなのウソだ<br>アーサーが仲間を殺すなんて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_290013")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "否定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルドレッド★★:てめえが信じようが信じまいが関係ねえ<br>アーサーは学園を襲い、多くの被害を出した
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C110_290014")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★モルドレッド★★:それはゆるぎない事実だ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C110_290015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園がバルバロイに襲われたあのとき
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_290017")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタンを見ていたアーサーの目…<br>あれは俺の知ってるアーサーの目じゃなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_290018")

	change_face(Actor001,"Sad")

	--★★ノワール★★:どんな理由があるのか知らないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_290019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:みんなを…ディナタンを傷つけようとするなら<br>戦わなきゃならない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_290020")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:俺たちも覚悟を決めるときが来たようだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_290022")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Sad02")
PlayActionDirect(Actor003,"to  Std_Sad02")
PlayActionDirect(Actor004,"to  Std_Worry")
wait_time(1.8)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
