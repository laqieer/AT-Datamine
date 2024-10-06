-- このluaスクリプトは、CO_101065_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-50,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_005)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.6, 0.1, 0.8, 0.6} , 1)
keep_ik_lookat(Actor001,Actor002,"J_Head")
set_enable_auto_lookat(Actor003,false)
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor003, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:例の盗賊の退治してきたよで、これがついでに頼まれてた書類の束
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020002")

-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ありがと♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020004")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★キッス★★:今回の依頼、どうだった？ちょっとカンタンすぎたかしら？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:まぁまぁといったところかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020006")


	--★★ノワール★★:ただ、俺が欲しい情報ってのは見つからなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020007")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:持って帰ってきたその書類の束が怪しいんじゃないかとも思ったけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020008")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:書かれている内容を見たのかしら？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:いや手紙とか書類を盗み見るのは好きじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ンフフ。感心ね～♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:依頼を完璧に達成してくれたお礼にこの書類の内容を教えちゃおうかしら
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020012")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Smile")

	--★★キッス★★:やっぱりまだちょ～っと早い・か・な♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020014")

	open_select_window_tag(Actor001,"Normal","CO_101065_03020016","CO_101065_03020017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それってどういう意味？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020019")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:言葉どおりの意味よ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020020")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、わかんないんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうしたら教えてもらえるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020023")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:あら、知りたがりねそういうガツガツした子、結構好きよ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020024")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そういうこと聞いてるんじゃないんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020025")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ノワール★★:…なんか、キッスさんにいいように遊ばれている気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020027")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ンフフ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020028")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "肯定3")
-- ▲直接出力

	--★★キッス★★:ラビットちゃんって本当にいい表情すると思って♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020030")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★キッス★★:ね？ラビットちゃんって誰かからなにか頼まれること、多いでしょ？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020032")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:え？ああ、うん…そうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020033")

-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力

	--★★キッス★★:「受けなきゃよかったかな」と思いながらもその頼まれごとを頑張っちゃうでしょ？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020034")


	--★★ノワール★★:えっ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020035")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:その結果、騙されちゃったこともあるでしょ？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101065_03020038","CO_101065_03020039")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なくは、ない…かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:正直でとてもよろしい♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020042")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★キッス★★:そういう依頼を断れるようになるといいわね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020043")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ない、と思うでも…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020045")

	change_face(Actor002,"Normal")

	--★★キッス★★:でも？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020046")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺が貧乏くじを引いたとしてもさ代わりに誰かが幸せになれるなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020047")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:それもアリなんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ンフフ。そうねそれもアリかもしれないわね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020049")

	goto Block2end

::Block2end::
	change_face(Actor002,"Normal")

	--★★キッス★★:強く生きてきたのね強く生きなきゃならない環境だったのかしら
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020051")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:今後、キミを騙して利用してやろうと悪いオトナがたくさん近づいてくると思う
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020053")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Smile")

	--★★キッス★★:でも…キミを大事にしてくれるオトナもきっと現れる
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020054")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:見極める目を養ってね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020055")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力

	--★★キッス★★:子供はオトナを頼っていいんだから♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03020056")

-- ▼直接出力
 setup_small_camera_start(Camera002)
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
set_enable_auto_lookat(Actor001,true)
lookat_delay_weight_reset(Actor001,0.6)
turn_lookat(Actor001,Actor003,0)
lookat_delay_weight(Actor003, {1, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor003,Actor001,"J_Head")
--フェードイン
setup_small_camera_start()
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんです、これ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020058")

-- ▼直接出力
PlayPartVoice("ジェラルド", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★酒場店主★★:キッスさんのお勘定
	Talk(Actor003,"NPCNAME_0263","speech","L","CO_101065_03020059")

	change_face(Actor003,"Normal")

	--★★酒場店主★★:今日はキミが払ってくれるって聞いてます
	Talk(Actor003,"NPCNAME_0263","speech","L","CO_101065_03020060")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんで、俺が…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020061")

-- ▼直接出力
PlayPartVoice("ジェラルド", "肯定2")
-- ▲直接出力

	--★★酒場店主★★:今月は飲み過ぎて財布がピンチだそうで
	Talk(Actor003,"NPCNAME_0263","speech","L","CO_101065_03020062")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:悪いオトナに利用された…っ！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03020063")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ジェラルド", "悩む")
-- ▲直接出力

	--★★酒場店主★★:キッスさん、誰かの困った顔を見るのが趣味ですからね…
	Talk(Actor003,"NPCNAME_0263","speech","L","CO_101065_03020064")

-- ▼直接出力
local trustParam = set_communication_rankup("キッス_コミュランク", "キッス_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
