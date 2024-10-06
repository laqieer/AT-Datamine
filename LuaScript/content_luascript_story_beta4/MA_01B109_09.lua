-- このluaスクリプトは、MA_01B109_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",197.3911,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera002 = SetTemplate("Actor002",17.26798,CharaPos110011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_007)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力

	--★★ランスロット★★:付き合ってくれないか、少し
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_090002")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:め、珍しいな<br>会いに来るなんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_090003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:会いに来てはいけないか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_090005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_090006","MA_01B109_090007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:歓迎するよ<br>今まで会えなかったぶん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_090009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:そのぶんぐらいは取り戻さないとな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_090010")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ランスロット★★:実はな、会いに来ようにも<br>立場上軽々しくは…少し、な
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_090011")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:だが、歓迎されているならしょうがない<br>これからはそれを口実に会いに来るよ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_090013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あまり来られても困るな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_090015")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:そう、だな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_090016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ランスロット★★:立場上、確かにな…生徒と教師であり<br>兄弟弟子ではあるが贔屓も良くない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_090017")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ランスロット★★:自重するよ、自重する
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_090019")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか用事でもあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_090021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ノワールにしか頼めないお願いだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_090022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺にしか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_090023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:X日後の地稽古の授業で<br>俺に付き合ってくれ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_090024")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…なんだかわからないが、わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_090025")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力

	--★★ランスロット★★:助かるよ<br>俺ひとりでは少し心もとなかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_090026")


	--★★ランスロット★★:最後の授業をしたいんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_090027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
