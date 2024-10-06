-- このluaスクリプトは、PT5_01_0041_2.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
-- ▼直接出力
MobsNo = 2
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
hideobj01 =get_object("geo_desk_item_02")
hideobj02 =get_object("geo_desk_item_04")
hideobj03 =get_object("geo_desk_item_07")
hideobj04 =get_object("geo_desk_item_10")
hideobj05 =get_object("geo_desk_item_13")
set_pos(hideobj01,{0,-20,0})
set_pos(hideobj02,{0,-20,0})
set_pos(hideobj03,{0,-20,0})
set_pos(hideobj04,{0,-20,0})
set_pos(hideobj05,{0,-20,0})
hideobj06 =get_object("geo_desk_item_06")
hideobj07 =get_object("geo_desk_item_15")
hideobj08 =get_object("geo_desk_item_16")
hideobj09 =get_object("geo_desk_item_01")
set_pos(hideobj06,{0,-20,0})
set_pos(hideobj07,{0,-20,0})
set_pos(hideobj08,{0,-20,0})
set_pos(hideobj09,{0,-20,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力

	--★★クリスティーナ★★:学園で生活していると<br>時折聖杯の名を耳にすることがあると思うけど
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00410002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クリスティーナ★★:みんなは<br>聖杯ってどんなものだと思う？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00410003")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:誰かに意見を聞いてみようかしら<br>…えーと、じゃあ、ノワールちゃん
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00410004")

	open_select_window_tag(Actor001,"Normal","PT5_01_00410005","PT5_01_00410006","PT5_01_00410007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:聖杯なんて<br>おとぎ話に出てくるものだろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00410008")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:あら、ノワールちゃんは現実主義者なのね<br>ちょっぴり意外だわ…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00410009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:すごく値打ちがあるお宝なんじゃないかな？<br>ひとつで数億ゼニーくらいになるような
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00410010")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:うん<br>それはそれで夢のある話よね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00410011")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:本当かどうかは定かじゃないけど<br>手にした者の願いをなんでも叶えてくれるって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00410012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:そうね<br>そうとらえている人が多いわよね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00410013")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:聖杯は数十年、数百年に一度この世界に姿を現し<br>手にした者の願いをなんでも叶える奇跡の宝物…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00410014")


	--★★クリスティーナ★★:伝承ではそうなっているわね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00410015")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クリスティーナ★★:アーサー王や円卓の騎士たちは<br>バルバロイを根絶すべく聖杯を探しているけれど
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00410016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力

	--★★クリスティーナ★★:奇跡の力を悪用するために<br>聖杯を探している人間もいると思うの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00410017")


	--★★クリスティーナ★★:もしもその人たちの手に聖杯が渡ってしまったら<br>この世界はどうなってしまうのかしらね？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00410018")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:実は私も聖杯を手に入れて<br>素敵な王子様と知り合えたらと思ってるんだけど
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00410019")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力

	--★★クリスティーナ★★:…こんなことが知られたら<br>アーサー王たちに怒られちゃうかしら？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00410020")

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
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
