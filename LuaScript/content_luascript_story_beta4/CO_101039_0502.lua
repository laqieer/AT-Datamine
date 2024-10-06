-- このluaスクリプトは、CO_101039_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor004,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.7,0.6)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor004,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.7,0.6)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor004,"J_Head")
lookat_weight(Actor003,0.4,0.1,0.7,0.6)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor004,Actor002,"J_Head")
lookat_weight(Actor004,0.5,0.1,0.7,0.6)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ルーシャス", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ルーシャス★★:なぜ継承者までいる
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020002")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:私が一緒に来てって言ったの
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05020003")

	PlayAction(Actor002,"to  Std_Talk")

	--★★フレン★★:いいでしょ？<br>「ひとりで来い」なんて言われてないし
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ルーシャス★★:あいかわらず<br>よくさえずる小鳥だ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020005")


	--★★ルーシャス★★:まあ、好きにしろ<br>どうせいずれ知られることだ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020006")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:どういう意味だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05020007")


	--★★ルーシャス★★:あいかわらず<br>せっかちなヤツだ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020008")

-- ▼直接出力
PlayPartVoice("ルーシャス", "挨拶")
-- ▲直接出力

	--★★ルーシャス★★:これから説明してやる<br>まずは大人しく聞け
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020009")


	--★★ルーシャス★★:ローラをローマ本国に行かせる
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05020012")

-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:無論、これには理由がある<br>今後の戦いを見据えた結果
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020013")


	--★★ルーシャス★★:あちらに置いてきてしまったものを<br>持ってくるべきと考えるに至った
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ルーシャス★★:誰かにローマとこことを行き来し<br>余まで届けてもらわねばならぬ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020015")


	--★★ルーシャス★★:ところが、ヴェルナルスは<br>ケガを負って今は動くことができぬ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020016")

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor003,"J_Head",0.8)
wait_time(0.6)
-- ▲直接出力

	--★★ルーシャス★★:であれば<br>ローマ軍の内情に詳しいローラが適任といえる
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020017")

-- ▼直接出力
PlayPartVoice("ローラ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ローラ★★:ルーシャス様…！
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_05020019")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ローラ★★:はい<br>謹んでお受けいたします
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_05020021")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フレン", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:なに言ってるの、ルーシャスくん！<br>ローラはまだケガが治ったばかりなんだよ！？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05020022")

-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:フレン、落ち着け
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05020024")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力

	--★★フレン★★:落ち着いてなんかいられないよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05020025")

	PlayAction(Actor002,"to  Std_Surp")

	--★★フレン★★:ローマ本国だったら私が行くよ！<br>私だってローマの生まれだもの！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05020026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力

	--★★ルーシャス★★:そなた、今のローマを知っているのか？<br>余の必要としているものがわかるのか？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020027")


	--★★フレン★★:わ、わからないけど…でも、そんなの<br>ルーシャスくんが教えてくれたらいいじゃない！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05020028")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ルーシャス", "挨拶")
-- ▲直接出力

	--★★ルーシャス★★:よい機会だ、小鳥よ。覚えておけ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020029")


	--★★ルーシャス★★:余がもっとも忌み嫌うもの<br>それは「時の浪費」だ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020030")


	--★★ルーシャス★★:そなたの妹が知っていることをそなたに説明する<br>これを時間の無駄といわずなんと言おう
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020031")

-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力

	--★★フレン★★:じっ、時間の無駄って…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_05020034","CO_101039_05020035","CO_101039_05020036")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ノワール", "激怒")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ふざけるな！<br>なにが時間の無駄だ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05020038")

	change_face(Actor001,"Anger")

	--★★ノワール★★:フレンの気持ちを考えたことがあるのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05020039")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ローラのことだけじゃない<br>フレンはお前のことだって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05020040")

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ルーシャス", "否定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ルーシャス★★:幾度も言わせるな、凡愚
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020041")

	change_face(Actor004,"Normal")

	--★★ルーシャス★★:此度の任務はローラが適任なのだ<br>ローラにしかできぬことなのだ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020042")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:この話、<br>ローラは本当に納得しているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05020044")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ローラ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:うん、納得してるよ
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_05020045")

-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:だって、ルーシャス様が私のことを考えて<br>与えてくれた任務だもの
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_05020046")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ローラのことを考えて、だって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05020047")

	change_face(Actor003,"Smile")

	--★★ローラ★★:そう。だから心配しないで
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_05020048")

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
wait_time(0.1)
-- ▲直接出力
	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ルーシャスは冷静に事を運ぶヤツだ<br>今回の件も後先考えずに起こした行動じゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05020050")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それにローラも<br>ローマとの往復に納得している
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05020051")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ここはいったん冷静になろう<br>そして、もしルーシャスが間違っていたのなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05020052")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そのときは<br>思いっきり怒ってやればいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05020053")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:そうは言ってもさあ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05020054")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
wait_time(0.1)
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ルーシャス★★:継承者、フレンを連れて出て行け<br>興奮状態が収まるまで話にならなそうだ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_05020056")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
wait_time(0.4)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:お姉ちゃん、私なら大丈夫だよ
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_05020058")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ローラ★★:私ね、ローマのためになにかしたいの<br>ローマに生まれた者として
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_05020059")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ローラ★★:それに、ずっとローマに行くわけじゃないよ<br>短い期間の往復を何度かするだけだから
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_05020060")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("フレン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★フレン★★:それは！<br>理解、してるけど…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05020061")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
wait_time(0.4)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ローラ", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ローラ★★:ノワールさん、お姉ちゃんをお願い
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_05020063")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05020064")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_フレン_ランクアップ5_3")
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
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
