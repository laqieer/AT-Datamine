-- このluaスクリプトは、CO_101011_0903.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111012_01","111012_01_h")
Include("content_adv_advsmall_111012_01","Template111012_01_h")
Include("content_adv_advsmall_111012_04","111012_04_h")
Include("content_adv_advsmall_111012_04","Template111012_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111012_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111012_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111012_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_003)
	InitializeTemplateRandomCamera111012_01()
	InitializeTemplate111012_01()
-- ▼直接出力
Hide(Actor003)
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
-- ▼直接出力
load_image("104000070", "content_still_10400007_image", "104000070_StillImage")
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111012_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111012_04,CameraPos111012_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111012_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111012_04,CameraPos111012_04_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111012_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName111012_04,CameraPos111012_04_003)
	InitializeTemplateRandomCamera111012_04()
	InitializeTemplate111012_04()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111012)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:誰もいない…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030002")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力

	--★★ギネヴィア★★:…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030003")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-165.888,0.8)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:？<br>玉座になにかあるみたい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030005")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
template2()
DontChangeRandomCamera(false)
setup_small_camera_start()
set_enable_auto_lookat(Actor002, false)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Talk")
wait_time(0.5)
se_play("SE_ADV_CO_101011_0903_GlassBall_Hit")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:これは…ギネヴィアが持っていたガラス玉？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030007")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:同じガラス玉がいっぱいある…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030009")

-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力

	--★★ギネマウア★★:そう<br>あれと同じガラス玉よ
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","CO_101011_09030010")

-- ▼直接出力
setup_small_camera_start(Camera001)
wait_time(1.0)
set_enable_auto_lookat(Actor001, false)
lookat_delay_weight(Actor001, {1.0, 0, 0.3, 0.5} ,0.5)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
lookat_delay_weight(Actor002, {1.0, 0, 0.3, 0.5} ,0.5)
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030011")

-- ▼直接出力
--ギネマウア,CHRNAME_GWENHWYMAWR @名前変更
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ギネマウア★★:このガラス玉は魔法の品なんかじゃない
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_09030013")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネマウア★★:キャメリアードの近くで採れた石や砂で作った<br>なんの変哲もないガラス玉なの
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_09030015")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:そのガラス玉を持って行ったのは<br>ギネマウアさんだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:やっぱり…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030018")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんな…<br>どうして…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030020")

	change_face(Actor003,"Anger")

	--★★ギネマウア★★:…ギネヴィア<br>あなたはノワール様のキラーズになったの
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_09030021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ギネマウア★★:ノワール様は世界を救う宿命をもつ御方
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_09030022")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ギネマウア★★:そのキラーズがいつまでも<br>私にくっついていてはいけない
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_09030023")


	--★★ギネマウア★★:このガラス玉が手もとにあるかぎり<br>あなたが私を頼ろうとするのなら
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_09030024")


	--★★ギネマウア★★:私は<br>あなたに真実を伝えないといけない
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_09030025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Pain")

	--★★ギネマウア★★:私の手で<br>これを葬り去らないといけない
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_09030026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ギネヴィア★★:そんな…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030027")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ノワール★★:ギネマウアさん、それは違うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030029")


	--★★ノワール★★:あなたや故郷を守りたいという想いが<br>ギネヴィアの強さなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:だから、あなたをそばに感じられる<br>そのガラス玉を宝物にしてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030031")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:お姉ちゃん…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030032")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:わたしはお姉ちゃんと<br>ずっと一緒にいたいよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030033")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:だから…ノワールとともに戦う<br>継承者のキラーズとして世界を救うの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030034")

-- ▼直接出力
lookat_delay_weight_reset(Actor002,1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030036")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:俺がギネヴィアをキラーズに選んだ理由は<br>俺だけを見ていてほしいからじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030037")


	--★★ノワール★★:あなたやみんなに弱いところを見せながらも<br>頑張るギネヴィアだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030038")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:一緒に世界を救えると思ったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030039")


	--★★ノワール★★:だから、ギネマウアさん<br>これからもギネヴィアの支えになってほしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030040")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ノワール…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030041")

	change_face(Actor003,"Sad")

	--★★ギネマウア★★:ノワール様…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_09030042")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Shy")

	--★★ギネマウア★★:…もう<br>世話のかかる妹なんだから
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_09030044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:はい<br>返すわ、ガラス玉
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_09030045")

-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:あーあ<br>あげちゃったこと本当は後悔してたのに
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_09030046")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:もらったものは返さないわよ、お姉ちゃん<br>にししっ♪
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030048")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_CO_101011_0903_GlassBall_Drop")
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Surprise")

	--★★ギネヴィア★★:あっ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","CO_101011_09030050")

-- ▼直接出力
PlayPartVoice("ギネマウア", "驚き")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor003,"Surprise")

	--★★ギネマウア★★:あっ！
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","N","CO_101011_09030051")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight_reset(Actor001 , 0.6)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,15.37,0.5)
set_enable_auto_lookat(Actor002,true)
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor003,true)
wait_time(0.5)
PlayActionDirect(Actor001,"to  Std_Surp")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんでこのタイミングで転ぶんだ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030053")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:しょうがないでしょ！<br>誰だって嬉しいときはなにかにつまずくものよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030054")

	change_face(Actor001,"Anger")

	--★★ノワール★★:つまずかないだろ！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030055")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ギネマウア", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:ああ…他のものと混じってしまって<br>どれがお父様のくれたガラス玉かわからなく…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_09030056")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わかるわよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030057")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030058")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:これ<br>これがパパのくれたガラス玉
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030060")

-- ▼直接出力
ShowImageItem(104000070)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:どうして<br>すぐにそれだとわかったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_09030061")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:魔法がかかってるもの<br>すぐにわかるわよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030062")

-- ▼直接出力
CloseTalkWindow()
HideImageItem()
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:パパがわたしとお姉ちゃんが<br>幸せになれるように魔法をかけてくれたんだから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030063")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:見間違うわけないわよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_09030064")

-- ▼直接出力
local trustParam = set_communication_rankup("ギネヴィア_コミュランク", "ギネヴィア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000070", "content_still_10400007_image", "104000070_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(111012)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111012_01)
	system.PreLoadRequest(CameraAssetBundleName111012_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
