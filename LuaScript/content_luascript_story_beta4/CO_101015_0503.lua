-- このluaスクリプトは、CO_101015_0503.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
 --黒背景読込
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
 -- 黒背景の表示
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
hotdog = setup_prop_object(10102001)
off_active(hotdog)
-- ▲直接出力
-- ▼直接出力
hotdog2 = setup_prop_object(10102001)
off_active(hotdog2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401014","001","401014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:お、おい、ノワール！どうした！？<br>どこへ行く！？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:いいから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030003")

-- ▼直接出力
PlayPartVoice("アーサー", "怒り")
-- ▲直接出力

	--★★アーサー★★:いいから、って…<br>なんの説明もないんだが！？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:急ぎの用だというからついてきたが<br>いったいなにが――
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030005")

-- ▼直接出力
 --白黒終了フェードアウト
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.8, 0.6} , 1)
keep_ik_lookat(Actor001,Actor002,"J_Head")
turn_lookat(Actor003,Actor002,0)
turn_lookat(Actor004,Actor002,0)
turn_lookat(Actor005,Actor002,0)
CloseTalkWindow() --疑似バトルならclose_speech_window(
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_女2", "驚き")
-- ▲直接出力

	--★★市民（女）②★★:アーサー様！
	Talk(Actor003,"NPCNAME_0193","speech","L","CO_101015_05030006")

	PlayAction(Actor003,"to  Std_Talk")

	--★★市民（女）②★★:アーサー様！お元気でしたか？<br>ずっとお見掛けしないので気になってて
	Talk(Actor003,"NPCNAME_0193","speech","L","CO_101015_05030008")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "肯定")
-- ▲直接出力

	--★★市民（中年男）②★★:なんだか、顔色悪いですよ？<br>B級グルメが足りてないんじゃないですか？
	Talk(Actor004,"NPCNAME_0194","speech","L","CO_101015_05030009")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("子供_女1", "喜び")
-- ▲直接出力

	--★★子供（女）★★:わー！アーサーさまだー！<br>ずっと来てくれないから、寂しかったよ～
	Talk(Actor005,"NPCNAME_0140","speech","L","CO_101015_05030010")

-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力

	--★★アーサー★★:みんな…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:…すまない。少し立て込んでいてな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030012")

	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:不安定な情勢で皆には気苦労をかける<br>心配なことも多いだろうが、しばし堪えてくれ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030013")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_女2", "肯定2")
-- ▲直接出力

	--★★市民（女）②★★:私たちが心配なのはアーサー様のことです<br>無理してるんじゃないかって
	Talk(Actor003,"NPCNAME_0193","speech","L","CO_101015_05030014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:俺の？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030015")

-- ▼直接出力
PlayPartVoice("市民_女2", "肯定")
-- ▲直接出力

	--★★市民（女）②★★:私たちのためなら無理をしてでも頑張ってしまう<br>アーサー様はそういうお方ですから
	Talk(Actor003,"NPCNAME_0193","speech","L","CO_101015_05030016")


	--★★市民（女）②★★:アーサー様はいつだって<br>私たちを守るために戦ってくれてる
	Talk(Actor003,"NPCNAME_0193","speech","L","CO_101015_05030018")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★市民（女）②★★:だからこそ私たちも<br>あなたが率いるログレスを信じられる
	Talk(Actor003,"NPCNAME_0193","speech","L","CO_101015_05030019")

-- ▼直接出力
PlayPartVoice("市民_女2", "笑い")
-- ▲直接出力

	--★★市民（女）②★★:信じて、頑張れるんです<br>だからアーサー様もあまり無茶しちゃダメですよ
	Talk(Actor003,"NPCNAME_0193","speech","L","CO_101015_05030020")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor002,Actor001,"J_Head")
wait_time(CHARA_IN_OUT)
setup_small_camera_start()
fadein(CHARA_IN_OUT)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:まさか、俺を心配してくれるとは<br>…皆、優しいな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:俺が王として至らないばかりに<br>皆を危険に晒してしまっている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030023")

-- ▼直接出力
PlayPartVoice("アーサー", "落胆")
-- ▲直接出力

	--★★アーサー★★:…もっと俺が強ければ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030025")


	--★★アーサー★★:聖杯や…不確かな伝説にすがらずとも<br>すべてを引き受けられる強い王であれば
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:アーサー…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101015_05030030","CO_101015_05030031","CO_101015_05030032")
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
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:至らなくなんかない<br>あんたはあのときできることをした
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030034")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺たちはそれを知ってる<br>この町の人だって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:お前がそう言ってくれるのはありがたいが<br>王は結果がすべてだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030036")

	change_face(Actor002,"Sad")

	--★★アーサー★★:俺の采配の結果、多くを守れなかった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030037")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だったら、ついてきてる俺たちや<br>心配してくれる町の人は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030038")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:それだって、あんたが王として<br>やってきたことの結果だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030039")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたは悪くない<br>悪いのはルーシャスや魔女だろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:そうかもな<br>だが向こうには向こうの考えがある
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030042")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★アーサー★★:敵は俺たちの都合よくなど動いてくれない<br>そう王は承知していなければならない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030043")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうやって全部自分で抱え込んで<br>それが、あんたが目指していた王の姿なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030044")

-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:それは…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030045")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あんただけじゃない<br>俺も守れなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030047")

	change_face(Actor001,"Sad")

	--★★ノワール★★:俺は…継承者なのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030048")

-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:ノワール…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030049")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★アーサー★★:すまない。お前にそんなことを<br>言わせるつもりはなかった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030050")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("アーサー", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:…まったく、俺が弱音を吐いてどうするんだ<br>お前のほうがよほど背負うものが大きいのに
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030051")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:みんながあんたを心配するのは<br>あんたが王様としてちゃんとやってきたからだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030053")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:いつも街の様子に目を配って<br>学園を守るために奔走して
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030054")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そんなあんたをみんなが見て知ってるから…<br>だからあんたを王と認めて、ついていくんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030055")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:ノワール…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030056")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…あーあ。なんか、腹減ったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030058")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ほら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030060")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
SkipDefaultMotion(Actor001)
SkipDefaultMotion(Actor002)
hotdog_offset = {0,0,0,0,0,0}
on_parent(hotdog,Actor001, "Loc_weapon_constrint_R", hotdog_offset)
hotdog2_offset ={0,0,0,0,0,0}
on_parent(hotdog2,Actor002, "Loc_weapon_constrint_R", hotdog2_offset)
PlayActionDirect(Actor001,"to EatIdle")
PlayActionDirect(Actor002,"to EatIdle")
 on_active(hotdog) 
 on_active(hotdog2) 
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:ホットドッグ…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030061")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:さっきあんたが町の人に囲まれてるときに<br>買っておいた。俺のおごりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030062")


	--★★アーサー★★:…こういうのは初めてだな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030064")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:…立派な王になると、誓ったんだ<br>あの頃、ホットドッグをほおばりながら
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030066")


	--★★アーサー★★:民と同じ目線に立ち、民とともに生きる<br>そんな立派な王様になると
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030067")


	--★★アーサー★★:…現実をまだなにも知らなかった子供の<br>青臭い誓いさ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030068")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:でも、忘れてないんだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05030069")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:…ああ。そうだ。忘れてはいない<br>忘れたりするものか
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030070")


	--★★アーサー★★:あの青い誓いは今も俺の胸にある<br>３人で食べたホットドッグの味とともにな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_05030071")

-- ▼直接出力
local trustParam = set_communication_rankup("アーサー_コミュランク", "アーサー_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10102001)
setup_prop_object_preload(10102001)
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401014","001","401014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
