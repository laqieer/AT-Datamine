-- このluaスクリプトは、MA_01105_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-143.4,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102009)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
-- ▼直接出力
	-- 背景移動回転スケール
	local bg = get_object("BG")
	set_pos(bg,{0,0,24})

	-- 固定モブ移動回転スケール
	local pro = get_object("Pro_1101_45")
	set_pos(pro,{0,0,24})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:キャメリアードから帰還後<br>ギネヴィアは自室でふさぎ込んでしまう
	Talk(Actor003,"telop","narration","N","MA_01105_011001")


	--★★テロップ★★:そんな中、ルーシャスがギネヴィアのもとを訪れ<br>キャメリアード奪還に協力することを告げる
	Talk(Actor003,"telop","narration","N","MA_01105_011002")


	--★★テロップ★★:ルーシャスの言葉の裏にある思惑を測りつつ<br>ノワールは円卓会議の場に向けて歩いていた
	Talk(Actor003,"telop","narration","N","MA_01105_011003")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:…戦時に祭りなど、とお思いですか？
	Talk(Actor003,"telop","narration","N","MA_01105_011004")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ティルフィング★★:…戦時に祭りなど、とお思いですか？
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MA_01105_010003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ティルフィング★★:はやるお気持ちもわかりますが<br>軍備も整い切っていないと聞きます
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MA_01105_010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ティルフィング★★:たまには羽を伸ばされては
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MA_01105_010005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MA_01105_010007","MA_01105_010008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ノワール★★:この雰囲気に慣れなくてさ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_010010")

	change_face(Actor001,"Normal")

	--★★ティルフィング★★:傭兵をなさっていたのであれば<br>人ごみは気になりますか？
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MA_01105_010011")

	change_face(Actor001,"Sad")

	--★★ティルフィング★★:…いつ背後から狙われるか、など
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MA_01105_010012")

	change_face(Actor002,"Sad")

	--★★ノワール★★:まだ…クセが抜けないな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_010013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ノワール★★:いいんだろうか？<br>こんなことしてて
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_010015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ティルフィング★★:気を張り詰め続けることを<br>否定はいたしません
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MA_01105_010016")

	change_face(Actor001,"Normal")

	--★★ティルフィング★★:ですが、各々の繋がりこそが<br>GSに向かうにあたっての通過点
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MA_01105_010017")

	change_face(Actor001,"Normal")

	--★★ティルフィング★★:遊興にふけることも<br>バルバロイ打倒に結び付く…
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MA_01105_010019")

	change_face(Actor001,"Normal")

	--★★ティルフィング★★:そういった学園なのでしょう
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MA_01105_010020")

	goto Block1end

::Block1end::
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ティルフィング★★:一時の平和を享受することこそ<br>恒久の平和を求める寄る辺となります
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MA_01105_010022")

	change_face(Actor001,"Sad")

	--★★ティルフィング★★:カレドニアに土地を奪われた民たちが<br>ログレスへ避難し、平穏を与えられている…
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MA_01105_010023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ティルフィング★★:大切にすべきですね<br>こういった時間は
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MA_01105_010024")

	change_face(Actor002,"Surprise")

	--★★ノワール★★:？<br>キミは祭りをまわらないのか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_010026")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ティルフィング★★:どうぞ御存分に。マスター
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MA_01105_010027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10102009)
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
