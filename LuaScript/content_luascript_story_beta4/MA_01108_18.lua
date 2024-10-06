-- このluaスクリプトは、MA_01108_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060012)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ガレス★★:あの似顔絵<br>ノワールが書いたのか～？
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_180002")

	change_face(Actor004,"Smile")

	--★★リオネス★★:まさか<br>ディナタンだろう？
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_180003")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:聞き込みのときに出した似顔絵ですか？<br>兄さんが書いたんですよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_180004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Surprise")

	--★★リオネス★★:へえ～。そっくりってわけじゃないけど<br>特徴をよくとらえられてるよな
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_180005")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ガレス★★:うんうん<br>一目でブライアンさんってわかったぞ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_180006")

	change_face(Actor004,"Sad")

	--★★リオネス★★:あたしなんて相手を直接見ながらでも<br>上手く描ける気がしないぞ
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_180007")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:人やモノの姿を覚えるのは<br>苦手じゃないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_180008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:手先も器用だし<br>自慢の兄ですハイ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_180009")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ガレスたちみたいに毎日変わらず<br>おいしい料理を作り続けられる方がスゴイよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_180010")

	change_face(Actor003,"Normal")

	--★★ガレス★★:レシピが頭に入ってるからできるだけだ<br>先人たちが受け継いできた技術がすごいんだ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_180011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:それを体現し続けられるのが<br>スゴイんですよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_180012")

	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Surprise")

	--★★ガレス★★:そういうものかなあ～？
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_180013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ガレス？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_180014")

	change_face(Actor003,"Sad")

	--★★ガレス★★:…くさいメシだと思われたのかなあ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_180015")

-- ▼直接出力
turn_chara(Actor004,20,0.5)
PlayActionDirect(Actor004,"to Wlk")
wait_time(0.5)
PlayActionDirect(Actor004,"to  Std_Talk")
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★リオネス★★:ガレス、ブライアンさんのことを言ってるのか？<br>気にするな、ガレスに非はまったくないぞ！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_180016")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:も、もしかしてブライアンさんが<br>ガレスさんたちになにかしてしまったんですか？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_180017")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Smile")

	--★★ガレス★★:食で人の心が変えられたりしたら<br>な～んて考えるんだ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_180019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガレス★★:少し傲慢かもしれないけど<br>牢屋に出すゴハンも美味しかったら…
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_180020")


	--★★ガレス★★:踏みとどまってくれることも<br>あるんじゃないか、って願ってたんだ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_180021")

	change_face(Actor003,"Sad")

	--★★ガレス★★:けど………
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_180022")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,1.0,0,0.4,0.2)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.5)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.5)
turn_chara(Actor004,-58,0)
-- ▲直接出力

	--★★ディナタン★★:兄さん<br>木に引っかかってコートが破れてる
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01108_180024")


	--★★ノワール★★:…また繕わないといけないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_180025")

-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
lookat_delay_weight_reset(Actor001,0.6)
set_enable_auto_lookat(Actor002,true)
lookat_delay_weight_reset(Actor002,0.6)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★リオネス★★:ブカブカすぎるんだろう！<br>仕立て直したらどうだ？
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01108_180026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")

	--★★ノワール★★:そうはいかないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_180027")

	change_face(Actor003,"Surprise")

	--★★ガレス★★:なんでだ？
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01108_180028")


	--★★ノワール★★:母さんが父さんへの想いを込めて<br>編んでくれたものだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_180029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:これは替えがきかないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_180030")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101060012)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
