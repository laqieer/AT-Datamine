-- このluaスクリプトは、CO_101012_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_03","110141_03_h")
Include("content_adv_advsmall_110141_03","Template110141_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_03,CameraPos110141_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_03,CameraPos110141_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_03,CameraPos110141_03_001)
	InitializeTemplateRandomCamera110141_03()
	InitializeTemplate110141_03()
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.5, 0.2, 0.8, 0.6} , 1) 
keep_ik_lookat(Actor001,Actor002,"J_Head")
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.8, 0.6} , 1) 
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…よいしょっと！<br>これで全部か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_03020002")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:うん。それで終わり<br>ありがとう、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03020003")


	--★★ディナタン★★:こっちも薬品の整理が終わったし<br>ちょっと休憩しよっか
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03020004")

-- ▼直接出力
setup_small_camera_end(Camera002)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルガン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モルガン★★:ふたりともありがとう<br>おかげで助かっちゃったわ
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101012_03020006")

	change_face(Actor003,"Normal")

	--★★モルガン★★:そうそう、ディナタン<br>あなたに預かってるものがあるのよ
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101012_03020007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:ありがとうございます<br>これは…手紙？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03020009")

-- ▼直接出力
PlayPartVoice("モルガン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モルガン★★:そう、愛のこもったお手紙よ
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101012_03020010")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ラブレター！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_03020012")

-- ▼直接出力
PlayPartVoice("モルガン", "喜び")
-- ▲直接出力

	--★★モルガン★★:驚くことないでしょ～？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101012_03020013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルガン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルガン★★:ディナタンはいつもこの療養院を手伝ってくれて<br>妖精みたいないい子って評判だし
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101012_03020014")

	change_face(Actor003,"Smile")

	--★★モルガン★★:それに…なんたって、五月女王だしね<br>あなたも変化を実感してるんじゃない？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101012_03020015")

-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力

	--★★ノワール★★:そ、そうなのか？ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_03020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0009")
-- ▲直接出力

	--★★ディナタン★★:そういえば確かに…<br>あれ以来話しかけてくれる人が増えたんです
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03020017")

-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルガン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルガン★★:ステージのディナタンを見て<br>ファンになっちゃったのかもしれないわね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101012_03020018")

-- ▼直接出力
PlayPartVoice("モルガン", "挨拶")
-- ▲直接出力

	--★★モルガン★★:よかったじゃない。ね、ノワールくん？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101012_03020019")

	open_select_window_tag(Actor001,"Normal","CO_101012_03020021","CO_101012_03020022")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ、よかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_03020024")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:ディナタンの良さが伝わったのはいいことだよ<br>…ラブレターの件はともかくとして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_03020025")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:友達ができないってずっと気にしてたし<br>これでひと安心だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_03020026")

	change_face(Actor002,"Shy")

	--★★ディナタン★★:兄さん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03020027")

-- ▼直接出力
PlayPartVoice("モルガン", "納得")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モルガン★★:理解のあるお兄さんで素敵ね、ディナタン
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101012_03020028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…はい！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03020029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:友達ができたのはいいけど…<br>ちょっと心配だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_03020031")

-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:心配？なにが？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03020032")

-- ▼直接出力
PlayPartVoice("モルガン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルガン★★:ノワールくんの気持ちわかるなあ<br>悪い虫が寄ってこないか、心配よねぇ
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101012_03020033")

	change_face(Actor003,"Smile")

	--★★モルガン★★:でもこういうときは喜んであげるのが<br>お兄ちゃんの役目だと私は思うわ
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101012_03020034")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:でも…このお手紙、どうしよう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03020036")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ど、どうしようって？<br>まさか付き合うっていうんじゃ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_03020037")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:ち、違うよ<br>そういうことじゃなくて！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03020038")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:返事を書かなきゃって思うんだけど<br>私、手紙ってあんまり書いたことないから…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03020039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:それに文章にもあんまり自信ないし…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_03020040")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは俺も自信ないな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_03020041")

-- ▼直接出力
PlayPartVoiceDirect("モルガン","0046")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルガン★★:なるほどねぇ。だったら、こういうのはどう？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","CO_101012_03020042")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start(Camera002)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "納得")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Normal")

	--★★ディナタン★★:…なるほど！その手がありましたね！
	Talk(Actor002,"CHRNAME_DINATAN","speech","N","CO_101012_03020044")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera002)
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to  Std_Worry")
wait_time(2)
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ディナタン_ランクアップ3_3")
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
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
