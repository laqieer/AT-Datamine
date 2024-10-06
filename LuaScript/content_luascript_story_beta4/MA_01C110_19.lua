-- このluaスクリプトは、MA_01C110_19.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_01","110041_01_h")
Include("content_adv_advsmall_110041_01","Template110041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110041_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110041_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_006)
	InitializeTemplateRandomCamera110041_01()
	InitializeTemplate110041_01()
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力

	--★★ギネヴィア★★:…んん～？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C110_190002")

-- ▼直接出力
wait_time(1.3)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_190004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:…なんかノワール、雰囲気変わった？<br>なんていうか…大人びたっていうか？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C110_190005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C110_190006","MA_01C110_190007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンとふたりで<br>生き延びるのに必死だったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_190009")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:あっちもこっちも<br>生活が一変しちゃってたもんね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C110_190010")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:でもこっちでは1ヶ月くらいなのに<br>ずっと長くいた気がするなんて不思議
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C110_190011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか？ガレスにも言われたけど<br>自分じゃわからないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_190013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:むしろ大人びたのはギネヴィアのほうだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_190014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:おやおや？大人の女の魅力ってやつ？<br>出てきちゃってますぅ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C110_190016")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ま、お互い色々ありましたってコトで
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C110_190018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…あぁ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_190019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…本当によかった<br>ふたりが無事で
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C110_190020")

-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺も<br>ギネヴィアたちが無事でよかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_190021")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:なにが起こってるのか<br>まだ全然わかんないけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C110_190022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:でも、きっとなんとかなるわよ<br>だってノワールが帰ってきたんだもん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C110_190023")


	--★★ギネヴィア★★:今までもなんとかしてくれたもんね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C110_190024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あぁ<br>…なんとかしないとな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_190025")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力

	--★★ギネヴィア★★:にしし…♪<br>頼りにしてるわよ、継承者様
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C110_190026")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
