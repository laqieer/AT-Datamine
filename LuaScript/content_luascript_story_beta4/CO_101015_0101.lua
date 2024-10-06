-- このluaスクリプトは、CO_101015_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_04","110111_04_h")
Include("content_adv_advsmall_110111_04","Template110111_04_h")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-10.084,CharaPos110111_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_001)
	InitializeTemplateRandomCamera110111_04()
	InitializeTemplate110111_04()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
RndCamera001 = RndCamera003
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
hotdog = setup_prop_object(10102001)
off_active(hotdog)
hotdog2 = setup_prop_object(10102001)
off_active(hotdog2)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:ちょっと小腹が減ったなぁ<br>なんか食べるものでも探すか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010002")


	--★★ノワール★★:確かこの先にホットドッグ屋があったよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010003")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Appear(Actor002)
Appear(Actor003)
set_pos(Actor001,CharaPos110111_04_005)
	turn_lookat(Actor001,Actor002,0)
	Camera001 = InitializeCharaCamera(CameraAssetBundleName110111_04, CameraPos110111_04_005, Actor001) --アクターのカメラを再設定
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あれ、あんたは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010005")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("アーサー", "挨拶")
-- ▲直接出力

	--★★アーサー★★:おっ、ノワールじゃないか！<br>お前もここのホットドッグを食べに？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ。まさか、あんたも？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010007")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:ああ！この店のホットドッグは俺の大好物でな！<br>お前とは気が合いそうだ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:お、そうだ！<br>ここはひとつ俺がご馳走してやろうじゃないか！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010009")

	open_select_window_tag(Actor001,"Normal","CO_101015_01010011","CO_101015_01010012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え！？<br>い、いいって。悪いよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010014")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:まぁ、そう言わず！<br>人の好意は素直に受け取るものだぞ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010015")

	change_face(Actor002,"Normal")

	--★★アーサー★★:王におごってもらえる機会などそうそうないぞ？<br>遠慮なく甘えるといい！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010016")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:はぁ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それじゃ遠慮なく<br>おごってもらおうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:うむ、素直なのはいいことだ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010020")

	change_face(Actor002,"Smile")

	--★★アーサー★★:気に入った！<br>今ならサイドメニューもつけてやろう！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010021")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、そこまではいいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010022")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:謙虚さも持ち合わせているとは<br>ますますもって気に入ったぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010023")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_end()
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor003,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:親父さん、ログレスドッグふたつ<br>ソース多めで頼む！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010025")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_男1", "肯定")
-- ▲直接出力

	--★★市民（中年男）★★:あいよ！
	Talk(Actor003,"NPCNAME_0019","speech","N","CO_101015_01010026")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
template2()
setup_small_camera_start()
hotdog_offset = {0,0,0,0,0,0}
on_parent(hotdog,Actor001, "Loc_weapon_constrint_R", hotdog_offset)
hotdog2_offset ={0,0,0,0,0,0}
on_parent(hotdog2,Actor002, "Loc_weapon_constrint_R", hotdog2_offset)
PlayActionDirect(Actor001,"to EatIdle")
PlayActionDirect(Actor002,"to EatIdle")
SkipDefaultMotion(Actor001)
SkipDefaultMotion(Actor002)
 on_active(hotdog) 
 on_active(hotdog2) 
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME )
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:ほら、お前のぶんだぞ<br>さあ、一緒に食おうじゃないか！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010028")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:本当にいいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:もちろんだとも<br>入学祝いってやつだな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010030")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:祝われるような経緯じゃなかったと思うけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010031")

-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:たしかに！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010032")

	change_face(Actor002,"Normal")

	--★★アーサー★★:だが俺はお前の入学を歓迎している<br>その気持ちの表れだと思ってくれ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…じゃあ、いただきます
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:どうだ、美味いか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010037")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:だろう！？<br>ここのホットドッグは最高だ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:このなんともいえないジャンクな味わい…<br>健康に悪そうな濃ゆ～いソース！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:ああ、実にたまらん！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010040")

	change_face(Actor002,"Surprise")

	--★★アーサー★★:ん？どうした
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010042")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:いや…こんなところに<br>王様がひとりで来ていいのか？って思ってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010043")

-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:よくないだろうな！　<br>なにせ仕事を残してきている！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010044")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:本当によくないやつだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:だが、新入生を気遣うのも<br>学長として大切な仕事だからな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010046")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:で、学園生活はどうだ？<br>青春は謳歌できているか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010048")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:青春？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:経緯はともあれ、<br>せっかく学園に通うことになったんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010050")


	--★★アーサー★★:ひとりの学生として、学園生活を楽しんで<br>青春を謳歌する権利がお前にはある
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:学長として俺は<br>お前の青春を心から応援しているぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010052")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:はあ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010053")

-- ▼直接出力
off_active(hotdog2) 
off_parent(hotdog2)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★アーサー★★:…っと、もうこんな時間か！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010054")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:さすがに帰らないとまた義兄さんに<br>ネチネチ言われかねん！それじゃあな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_01010055")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:もう食べ終わったのかよ！？<br>早すぎだろ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010057")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:…変な王様
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_01010058")

-- ▼直接出力
local trustParam = set_communication_acquired("アーサー_コミュランク", "アーサー_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
RndCamera001 = RndCamera003
setup_prop_object_preload(10102001)
setup_prop_object_preload(10102001)
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_04)
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
