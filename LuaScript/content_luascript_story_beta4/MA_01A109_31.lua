-- このluaスクリプトは、MA_01A109_31.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-10,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01A109_311001")


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01A109_311002")


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01A109_311004")


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01A109_311005")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★知将ケイ★★:ロンディニウムをローマとバルバロイより奪還<br>人々の誤解はまだ解ききれたわけではないが…
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_310002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★知将ケイ★★:大陸とルーシャスの繋がりを断ち<br>島の南部の脅威を取り除けたのは朗報だ
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_310003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:魔女どもはカレドニア城に戻ったんだろうな<br>ローマの中心拠点はアソコってこった
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A109_310004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:小細工は要らないわ<br>早く突っ込んで終わりにしましょ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_310006")

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★知将ケイ★★:聖杯探索の進捗を見つつ<br>カレドニアへの進軍準備を急ごう
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_310007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★知将ケイ★★:ひとまずは休養を。先手は打たれたが<br>立て直すにはじゅうぶんな戦果だ
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_310008")

-- ▼直接出力
set_common_look_at(Actor003,Actor004,0.6)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:予想外の助太刀があったものね<br>ノワール先輩？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_310010")


	--★★ギネヴィア★★:あの子、どこの子？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_310012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor004,"Normal","MA_01A109_310014","MA_01A109_310015","MA_01A109_310016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール★★:ただの知り合いだよ
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A109_310018")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:…やめた
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_310019")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:ふふ。疑いたくないや
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_310020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ノワール★★:綺麗な子だよな
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A109_310022")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:き
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_310023")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:おやおやおやおやおやおやおーや<br>まあまあまあまあまあまあまーあ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A109_310024")

-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:わたしに言ってくんないわけね<br>そーゆーことは…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_310025")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール★★:初対面だよ
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A109_310027")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:いやそれは無理があるだろ<br>知ってるツラしてたぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A109_310028")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ギネヴィア★★:…間に合わせのウソってのが<br>一番サイアクよ、ノワール
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_310029")

	goto Block1end

::Block1end::
-- ▼直接出力
set_enable_auto_lookat(Actor004,true)
change_face(Actor004,"Normal")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★知将ケイ★★:ラヴェインとその妹君のことであるな？
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_310031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:ＧＳも済ませてて…<br>どこに隠れてたのかしら、あんな逸材
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_310032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:円卓の騎士並みの実力だったぜ<br>その兄貴だけじゃなくてエレインって子もさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A109_310034")

-- ▼直接出力
 --PlayPartVoice("ケイ", "納得")
-- ▲直接出力

	--★★知将ケイ★★:ログレスの同盟領アストラットの出身でな<br>仔細は当人から聞くと良い、個人情報なのでね
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_310035")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力

	--★★知将ケイ★★:引き続きローマ対策班には力を貸してくれる<br>ギネヴィア様が仰せのように、逸材だよ
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_310036")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力

	--★★ギネヴィア★★:…ま、聞きたいことはほかにもあるんだけどね<br>もっと気になることが
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A109_310037")

-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★知将ケイ★★:なんだね、それは？
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A109_310038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガウェイン★★:…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A109_310039")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ノワール★★:…当人から聞くことにするよ<br>個人情報だからな
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A109_310040")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
