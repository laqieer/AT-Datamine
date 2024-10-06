-- このluaスクリプトは、EA_001_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_003)
	Camera002 = SetTemplate("Actor002",-95,CharaPos110031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_004)
	Camera003 = SetTemplate("Actor003",100,CharaPos110031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_002)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
-- ▼直接出力
lookat_weight(Actor002, {0.8, 0, 0.6, 0.2})
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{8.54,0,-24.79})
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115034)
	Actor001 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0016")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ラグネル★★:大きな声出すよ！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012002")

-- ▼直接出力
PlayPartVoiceDirect("ケイ","0033")
-- ▲直接出力

	--★★ケイ★★:出しているではないか、すでに
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0018")
-- ▲直接出力

	--★★ラグネル★★:ヒト呼ぶよ！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012005")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ケイ★★:素直に従えば悪いようにはせん<br>お互い気持ち良く済ませよう──…
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012006")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0031")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor001,"Pain")

	--★★ラグネル★★:ぅうアーーーーーッッ！！！！<br>誰かー――――ッッ！！！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","N","EA_001_012008")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
on_active(Actor003)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat_position(Actor003,CharaPos110031_01_002[1],CharaPos110031_01_002[2],CharaPos110031_01_002[3],0)
slidemove(Actor003,CharaPos110031_01_002[1],CharaPos110031_01_002[2],CharaPos110031_01_002[3],2.0)
setup_small_camera_start()
wait_time(1.5)
setup_small_camera_start(Camera003)
wait_time(0.5)
turn_chara(Actor003,100,0.1)
wait_time(0.1)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","EA_001_012011","EA_001_012012","EA_001_012013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ノワール★★:ケイ、見損なったぞ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_012015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:…なにを誤解している？
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012016")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,228.683,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0021")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラグネル★★:ケイ先生があたしを<br>いいよーにしようとしてるんだよ！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ケイ","0019")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:言いかたを考えたまえ
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0034")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:ラグネル、なにをやらかした？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_012020")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,228.683,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ラグネル★★:ノワール！ケイ先生に言ってやってよ！<br>あたしはなんにもやらかしてないのにさぁっ！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:なにも成し遂げられておらぬから<br>この結果だと言っているのだ
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012022")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ノワール★★:関わらないでおこう…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_012024")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,228.683,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Greet_one")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:あっノワール！！ちょっと来て来て！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:ちょうどいい、様々な誤解が生じる前に<br>ノワールへ仲立ちを頼もうか
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012026")

-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0025")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:…か、関わらざるをえない…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_012027")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ケイ★★:騎士たちの戦いに<br>手芸がなんの役に立つのか、という話でな
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:…手芸？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_012030")

-- ▼直接出力
lookat_delay_weight_reset(Actor001 , 0.6)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,141,0.5)
wait_time(0.5)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Angry")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0019")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ラグネル★★:カワイイじゃん！<br>そのメガネ曇ってるんだよ！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ケイ", "0018")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ケイ★★:廃部だ
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012032")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0020")
-- ▲直接出力

	--★★ラグネル★★:横暴だよ、五月祭まであと四日だよ！？<br>それにあたしたち騎士である前に学生だよ？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012033")

-- ▼直接出力
PlayPartVoiceDirect("ケイ", "0015")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:授業中の居眠りが増えていると報告があったが<br>祭りの準備が佳境ゆえかね？
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012034")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to  Std_Surp")
change_face(Actor001,"Surprise")
wait_time(WAIT_TIME_LONG)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ケイ", "0033")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:だからいつまでも『部』に昇格できんのだ<br><ruby=サークル>同好会</ruby>であっても存続のためには２つ条件がある
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:ひとつ、部員数…最低構成人数は『３人』<br>ふたつ、実績…これは言わずもがな
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012037")


	--★★ケイ★★:貴公らはそのどちらも満たせていない<br>騎士である前に学生だというなら──
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012039")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:学業をおろそかにせず、騎士としても模範となり<br>学園のルールを遵守してもらいたいものだが？
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012040")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ケイ★★:ぐうの音も出まい？
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012042")

-- ▼直接出力
SkipDefaultMotion(Actor001)
set_enable_auto_lookat(Actor001, false)
lookat_delay_weight_reset(Actor001 , 0.6)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor001,180,0.7)
PlayActionDirect(Actor001,"to  Std_Sad02")
SkipDefaultMotion(Actor001)
PlayPartVoiceDirect("ラグネル", "0021")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラグネル★★:ぐ、ぐ、ぐぅぅゥゥッ～…！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012043")


	--★★ノワール★★:ぐうの音は出てる…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_012044")

-- ▼直接出力
change_face(Actor003,"Normal")
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:祭壇の剣を抜き放ったというノワールの現れ<br>バルバロイの活性化、迫る戦いの予兆…
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012045")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ケイ★★:ログレスは予断を許す状況ではない<br>これは決定事項である。帰ってよろしい
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012047")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
lookat_weight_reset(Actor001)
PlayActionDirect(Actor001,"to Std_Loop")
SkipDefaultMotion(Actor001)
wait_time(4.0)
lookat_delay_weight(Actor001, {0.9, 0.02, 0.6, 0.1}, 1.0)
keep_ik_lookat(Actor001,Actor003,"J_Head")
change_face(Actor001,"Laugh")
wait_time(1.6)
setup_small_camera_start(RndCamera005)
PlayActionDirect(Actor001,"to Finger")
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:部存続条件ひとつ目、部員数クリア！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012049")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
change_face(Actor003,"Surprise")
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:んッ！？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_012051")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ケイ★★:…なるほど3人目の部員は貴公か<br>そういうことにするとしても──
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012052")

-- ▼直接出力
setup_small_camera_end()
lookat_delay_weight_reset(Actor001 , 0.6)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,141,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to  Std_Joy")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力

	--★★ラグネル★★:あたしたちの廃部は学園の大損失！<br>『カワイイ』はみんなに必要なものだもん！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012054")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:ならば、ブリテンで生きとし生ける者すべてに<br><ruby=カワイイ>ぬいぐるみなぞ</ruby>を欲しがらせることができるか？
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012055")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
CloseTalkWindow()
wait_time(WAIT_TIME_NORMAL)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Pain")

	--★★ラグネル★★:………で、き、る！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012057")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:できないだろ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_012058")

-- ▼直接出力
PlayPartVoice("ケイ", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ケイ★★:フフッ、良かろう！
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012059")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:良くないだろ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_012060")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:実績を作ろうと言うのだろう？<br>このケイ、ルールを守る者には寛大だ
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012061")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ケイ★★:仮にブリテン全土の人間が<br>ぬいぐるみを欲しがれば廃部は撤回としよう
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012062")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:期限は４日後──<br>五月祭が終わるまでだ。いかがかな？
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012063")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0039")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:ヨシッ！おっけー！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012064")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:イヤ、オッケーじゃないだろ期限短すぎるし<br>どうなったら達成される条件なんだそれは
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_012065")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:それこそ<br>針穴に糸を通すようなものだろうがね
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012066")

	change_face(Actor001,"Normal")

	--★★ラグネル★★:…針に糸が通らなくたってね──
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012068")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ケイ★★:声がデカイだけではな
	Talk(Actor002,"CHRNAME_KAY","speech","L","EA_001_012070")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:通るまでやんなきゃ<br>手芸は始まらないからね！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_012071")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115034)
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
