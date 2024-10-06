-- このluaスクリプトは、CO_101063_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114071_01","114071_01_h")
Include("content_adv_advsmall_114071_01","Template114071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114071_01,CameraPos114071_01_004)
	Camera002 = SetTemplate("Actor002",115,CharaPos114071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName114071_01,CameraPos114071_01_003)
	InitializeTemplateRandomCamera114071_01()
	InitializeTemplate114071_01()
-- ▼直接出力
 --黒背景読込
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "喜び")
-- ▲直接出力

	--★★クリスティーナ★★:やっぱりここは何度来てもいいわね～
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010008")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:来るたびに美しくなれてる気がするもの！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010009")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:クリスさん<br>そんなに何度も来てるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_00010010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力

	--★★クリスティーナ★★:それはもう！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:お肌のツヤをケアしてくれる薬湯に体の内側を綺麗にする蒸し風呂…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010012")


	--★★クリスティーナ★★:湯上りに用意されたヘルシーで美味しい食べ物と飲み物…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010013")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:極めつけにここでしか買えない期間限定・数量限定の美容グッズ…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "喜び")
-- ▲直接出力

	--★★クリスティーナ★★:ローマン・バス、最・高！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010015")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ノワール★★:ははは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_00010016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:それじゃ、ノワールちゃんどこから回りましょうか？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101063_00010018","CO_101063_00010019","CO_101063_00010020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:美肌の湯、正直ちょっと興味ある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_00010022")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:あらあら？あらあらあらあら♪
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ノワールちゃんもとうとうスキンケアに興味をもちはじめちゃったのね！？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010024")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:い、いや、そういうわけじゃないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_00010025")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ただ、本当にお湯につかっただけで肌が綺麗になったりするのかなって思って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_00010026")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:百聞は一見に如かず！効果は試してみるのが一番よ！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:私がしっかりじっくりたっぷりねっとりケアのしかたを教えてあげるわ。行きましょ♪
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010028")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,69.6,0.5)
wait_time(0.5)
slidemove(Actor002, 0.06, 0.605, 2.93, 1.3)
wait_time(1.3)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？ちょっと待っ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_00010029")

-- ▼直接出力
 --黒背景に移行
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うわあああ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_00010030")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ、蒸し風呂で
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_00010033")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:あら！なかなかツウな選択するじゃない♪
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:蒸し風呂は、水風呂と交互に入ることで体の調子を内側から整えてくれるのよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010035")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ体を温めるだけじゃないのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_00010036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:熱いのと冷たいのを繰り返すことで効果的に体に刺激を与えられるんですって
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:最後に休憩がてら外気浴をするまでが１セットよさあ、行ってみましょうか
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010038")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:順番としてはあんまり良くないのかもしれないけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_00010041")

	change_face(Actor001,"Normal")

	--★★ノワール★★:まずは腹ごしらえしないか？ちょっとお腹空いちゃってるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_00010042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:クリスさんオススメのローマン・バスグルメも気になるし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_00010043")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:あら、そう？なら私イチ押しの<br>ご飯屋さんに連れてってあげるわね！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:クリスさんイチ押しか…楽しみだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_00010045")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ええ、期待していいわよ♪
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_00010046")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"クリスティーナ")
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
	InitializeLoad_Preload()
	load_area_scene_preload(114071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
