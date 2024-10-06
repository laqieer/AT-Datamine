-- このluaスクリプトは、CO_101025_0202.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110161_02","110161_02_h")
Include("content_adv_advsmall_110161_02","Template110161_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110161_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110161_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110161_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_004)
	InitializeTemplateRandomCamera110161_02()
	InitializeTemplate110161_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110161)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
DontChangeRandomCamera(true)
Prop_01 = get_object("geo_desk_item_09")
set_pos(Prop_01, {0,0,1.6})
Prop_02 = get_object("geo_chair_14")
set_pos(Prop_02, {1.05,0,3.13})
set_rot(Prop_02,{0,0,0})
tegami = setup_prop_object(10106003)
tegami_offset = {0,0,0,0,0,0}
off_active(tegami)
set_rot(Actor001,{0,180,0})
set_enable_auto_lookat_all(false)
change_face(Actor001,"Sad")
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:えっと…ここが探偵事務所？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定3")
-- ▲直接出力

	--★★クレア★★:そうよ<br>好きな場所に座って
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020003")


	--★★ノワール★★:座って、って言われてもなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:これ、全部調査の依頼か？<br>たくさん来てるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:ええ<br>最近、増えているの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020007")

	PlayAction(Actor002,"to  Std_Worry")

	--★★クレア★★:少し前までは<br>行方不明のペットさがしばかりだったけれど
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020008")


	--★★クレア★★:最近は<br>おもしろい依頼も届くようになったわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020009")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:へえ、たとえば？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020010")

-- ▼直接出力
setup_small_camera_start(Camera003)
on_parent(tegami,Actor003, "Loc_weapon_constrint_L", tegami_offset)
on_active(tegami)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to ReadLetter")
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:浮気調査、尋ね人、異臭騒ぎ、謎のうめき声<br>おもちゃの捜索、魔物の生態調査
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_02020012")

-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:エトセトラ、エトセトラ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020013")

	open_select_window_tag(Actor001,"Normal","CO_101025_02020015","CO_101025_02020016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
off_parent(tegami)
off_active(tegami)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:クレアとヴォールスだけで<br>この依頼を全部さばけるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:大半は<br>依頼内容を見ただけで解決できるわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020019")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:見ただけで！？<br>それはすごいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020020")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("クレア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:依頼人に結果を知らせるほうが大変だわ<br>ノワールには走り回ってもらわないと
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020021")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:探偵の助手ってそういうこと…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
off_parent(tegami)
off_active(tegami)
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:クレアは街や学園のみんなから<br>頼りにされているんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:ええ、ありがたいことにね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020025")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("クレア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:依頼がなければ<br>好奇心のやりどころに困ってしまう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020026")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:好奇心がクレアの原動力だからな
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_02020027")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:さしあたって俺はなにをすればいい？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020029")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:まずは<br>あなたの適正を見てみたいの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020030")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クレア★★:そこにあるなかから<br>気になる依頼を選んで
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020031")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:そうだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101025_02020034","CO_101025_02020035","CO_101025_02020036")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これなんてどうだ<br>「最近、夫の帰りが遅いです」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020038")

	change_face(Actor001,"Normal")

	--★★ノワール★★:「若々しくなり肌のツヤもよくなっています<br>理由を聞いても整っただけとしか答えてくれず」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020039")

	change_face(Actor001,"Normal")

	--★★ノワール★★:「きっと愛人ができたに違いありません<br>調べてください」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:ローマン・バスに通い始めたのね<br>財布を見れば会員証があるはずよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020041")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…えっと、俺が確認を？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020042")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_pos(Actor001,{1.9,0,7.2})
change_face(Actor001,"Normal")
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{1.9,0,4},2)
fadein(FADE_TIME)
wait_time(1.8)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:言ったとおりだった<br>穏便な話し合いで解決できたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020044")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:お疲れさま
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020045")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これなんてどうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020047")

	change_face(Actor001,"Normal")

	--★★ノワール★★:「最近、家の近所からうめき声が<br>　ひっきりなしに聞こえます。怖い！」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020048")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:家の場所は…なるほど、あそこね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020050")

	change_face(Actor002,"Normal")

	--★★クレア★★:建物の間を風が抜けている音じゃないかしら<br>隙間を木の板かなにかで塞げば止むはずよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020051")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…えっと、俺がやってくるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020052")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_pos(Actor001,{1.9,0,7.2})
change_face(Actor001,"Normal")
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{1.9,0,4},2)
fadein(FADE_TIME)
wait_time(1.8)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:言ったとおりだった<br>静かになったって喜んでたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020054")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:お疲れさま
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020055")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これなんてどうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020057")

	change_face(Actor001,"Normal")

	--★★ノワール★★:「ママがだいじにしていた<br>きらきらのわっかがないの」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020058")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…これって結婚指輪のことだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020059")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:いい推理ね<br>わたしもそう思うわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020060")

	change_face(Actor002,"Normal")

	--★★クレア★★:なくしものはたいていソファの下か<br>ラックの裏、排水溝の底のどこかにあるはず
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020061")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…えっと、俺が探しに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020062")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_pos(Actor001,{1.9,0,7.2})
change_face(Actor001,"Normal")
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{1.9,0,4},2)
fadein(FADE_TIME)
wait_time(1.8)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…最終的に<br>その子のズボンのポケットから出てきた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020064")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("クレア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:それは…お疲れさま
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020065")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:じゃあ、次はこの依頼の解決をお願い
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020067")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ま、まだあるのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020068")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_animationbattlecontroller(Actor001,1,false)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"ToAbnormal")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:今日だけでだいぶ依頼を片付けられたわ<br>ありがとう、ノワールのおかげよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020070")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:た、探偵の助手って<br>こんなに体力を使うんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02020071")

-- ▼直接出力
PlayPartVoice("クレア", "肯定3")
-- ▲直接出力

	--★★クレア★★:その経験はきっと<br>今後の調査の役にも立ってくれるわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020072")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:期待してるわよ、ノワール
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02020073")

-- ▼直接出力
local trustParam = set_communication_rankup("クレア_コミュランク", "クレア_親密度")
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
	InitializeLoad_Preload()
	load_area_scene_preload(110161)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
setup_prop_object_preload(10106003)
tegami_offset = {0,0,0,0,0,0}
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110161_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
