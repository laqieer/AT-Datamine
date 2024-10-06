-- このluaスクリプトは、EA_009_041.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110901_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_008)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
Hide(Actor005)
set_pos(Actor005, {2.01, 0, 5.48})
-- ▲直接出力
-- ▼直接出力
force_lipsync(Actor004,"Close1")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Comical")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115904)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0034")
-- ▲直接出力

	--★★ノワール★★:『力を奪う魔術師』…<br>奴はいったい何者なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン", "0034")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:わかりません…皆さんの力を奪って<br>なにがしたいんでしょう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0410003")


	--★★エレイン★★:それに力をあるべきところに集結させるって…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0410004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン", "0034")
-- ▲直接出力

	--★★ラヴェイン★★:その辺りは本人に聞くほかないでしょう<br>それより気になるのは、バルバロイの動きです
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_009_0410005")

	change_face(Actor004,"Surprise")

	--★★ディナタン★★:…！
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_009_0410006")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラヴェイン★★:あの場のバルバロイたちは<br>魔術師が去ると同時に姿を消しました
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_009_0410007")


	--★★ラヴェイン★★:その動きはまるであの魔術師に<br>統率されているかのようでした
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_009_0410008")

	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:…なによりバルバロイたちは<br>彼の利となる行動をとっている
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_009_0410009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0008")
-- ▲直接出力

	--★★ノワール★★:確かに…力を奪われた生徒たちは皆<br>バルバロイ討伐の為に出撃した奴らだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:そしておそらくバルバロイと戦っている<br>隙を突かれて力を奪われた――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410011")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン", "0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラヴェイン★★:私たちもノワールさんが気づいてくれなければ<br>危うかったでしょうね
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_009_0410012")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:一度や二度なら偶然と片付けることもできます<br>ですがここまで続くとなれば…
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_009_0410013")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera090)
Appear(Actor005)
character_in_move_walk(Actor005,CharaPos008,2.2,0)
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera005)
PlayPartVoiceDirect("キッス", "0008")
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor002,Actor005,"J_Head")
keep_delay_ik_lookat(Actor004,Actor005,"J_Head",1.0)
change_face(Actor002,"Normal")
change_face(Actor004,"Normal")
-- ▲直接出力

	--★★キッス★★:彼とバルバロイが<br>繋がっていると考えるほうが自然、よね
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410015")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor004, true)
-- ▲直接出力

	--★★キッス★★:
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410016")


	--★★キッス★★:それでようやく調査結果がまとまったから<br>伝えに来たってわけ
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410017")

	change_face(Actor005,"Anger")

	--★★キッス★★:結論から言うと…ラビットちゃんたちが出会った<br>そいつが噂の『力を奪う魔術師』で間違いないわ
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","EA_009_0410019")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("キッス", "0007")
-- ▲直接出力
	close_cutin()
	change_face(Actor005,"Normal")

	--★★キッス★★:
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410020")


	--★★キッス★★:身体能力を奪う怪しげな魔術師がいるって
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410021")


	--★★キッス★★:その魔術師はバルバロイに冒険者たちを襲わせて<br>混乱に乗じて遠隔から魔法をかけていたらしいの
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410022")


	--★★キッス★★:
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410023")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:特別な力…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410025")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("キッス", "0008")
-- ▲直接出力

	--★★キッス★★:だからこの学園の生徒を<br>ターゲットにし始めたのかもね
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410026")

	PlayAction(Actor005,"to  Std_Talk")

	--★★キッス★★:この学園にはあちこちから優秀な子供たちが<br>集まっているでしょう？
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410027")


	--★★キッス★★:ここにもほら<br>ラビットちゃんみたいな
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0046")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういえば俺たちにも魔法を使おうとしてたな<br>なんだか迷ってるみたいだったけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("キッス", "0034")
-- ▲直接出力

	--★★キッス★★:もしかしたら、奪いたい力の持ち主が多くて<br>迷っちゃったのかもねぇ
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410030")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0034")
-- ▲直接出力

	--★★ノワール★★:奪いたい力か…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410031")

-- ▼直接出力
bgm_play("BGM_ADV_Comical")
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_009_0410033","EA_009_0410034","EA_009_0410035")
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
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
PlayPartVoiceDirect("ノワール", "0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:エレインの美貌かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410038")

-- ▼直接出力
PlayPartVoiceDirect("エレイン", "0028")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:へぇ！？<br>な、な、なに言ってるんですか！？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0410039")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:？俺、なにか変なこと言ったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410040")

	change_face(Actor004,"Anger")

	--★★ディナタン★★:………
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_009_0410041")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("キッス", "0033")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★キッス★★:ちょっとラビットちゃんったら、口説くにしても<br>もう少しTPO考えたほうがいいわよ
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410042")

	change_face(Actor004,"Anger")

	--★★ディナタン★★:（じとーっ…）
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_009_0410043")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、そんなつもりじゃ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410044")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ラヴェインの頭脳かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410047")

-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン", "0014")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラヴェイン★★:そう言っていただけるのは嬉しいのですが<br>特別な力と言うほどのものじゃありませんよ
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_009_0410048")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも試験ではいつもトップクラスだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410049")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン", "0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラヴェイン★★:試験の点は普段から授業を聞いていれば<br>とれるものですから
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_009_0410050")

-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…むしろ俺が欲しいな、ラヴェインの頭脳
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410051")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺のコミュ力かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410054")

	change_face(Actor002,"Normal")

	--★★エレイン★★:………
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0410055")

	change_face(Actor003,"Normal")

	--★★ラヴェイン★★:………
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_009_0410056")

	change_face(Actor005,"Normal")

	--★★キッス★★:………
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410057")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0014")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…あの、冗談なんで、笑ってもらえると
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410058")

-- ▼直接出力
PlayPartVoiceDirect("エレイン", "0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:えっ！？冗談だったんですか！？<br>すみません、なるほどーって思ってました…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0410059")

	goto Block1end

::Block1end::
-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera005)
lookat_weight(Actor002,0.5,0.1,0.5,0.2)
lookat_weight(Actor004,0.5,0.1,0.5,0.2)
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor004, true)
change_face(Actor002,"Normal")
change_face(Actor004,"Normal")
PlayPartVoiceDirect("キッス", "0007")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★キッス★★:…まあ、ここまでの情報はラビットちゃんたちが<br>掴んでいるものとそう大差ないわよね
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410061")

	change_face(Actor005,"Normal")

	--★★キッス★★:だからここでとっておきの情報――
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410062")

	change_face(Actor005,"Anger")

	--★★キッス★★:実はあの魔術師が剣の祭壇で<br>バルバロイを呼び出しているそうなの
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410063")

-- ▼直接出力
setup_small_camera_start(Camera090)
-- ▲直接出力

	--★★全員★★:！！！
	Talk(Actor006,"NPCNAME_0394","speech","L","EA_009_0410064")

-- ▼直接出力
wait_time(0.8)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:バルバロイを呼び出して…！？<br>だからバルバロイが奴に従っていたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410065")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン", "0046")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラヴェイン★★:もしそれが事実なら…何度討伐しても<br>バルバロイが湧いて出る理由にも説明がつきます
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_009_0410066")

-- ▼直接出力
PlayPartVoiceDirect("エレイン", "0034")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:で、でも…普通の人間に<br>そんなことできるんですか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0410067")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン", "0034")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ラヴェイン★★:恐らく彼は普通の人間ではありません<br>いや、もはや<dot>人間ではない</dot>
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_009_0410068")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410070")

-- ▼直接出力
PlayPartVoiceDirect("キッス", "0008")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★キッス★★:
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410071")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410072")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★キッス★★:本来、バルバロイに憑かれた人間は<br>あっという間に存在を喰われて人格もなくなるわ
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410073")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キッス★★:けどキラーズ因子を多く持つ人間に限り<br>まれに憑かれたバルバロイを従えることがある
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410074")


	--★★キッス★★:バルバロイの悪意と同調することでね<br>ラビットちゃんは覚えがあるんじゃない
	Talk(Actor005,"CHRNAME_KISS","speech","L","EA_009_0410075")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…ライエンスか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410076")

-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン", "0046")
-- ▲直接出力

	--★★ラヴェイン★★:もし、この推測が合っているのであれば…
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_009_0410077")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0007")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ああ。放っておくわけにはいかない<br>剣の祭壇に急ごう…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0410078")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Comical")
	InitializeLoad_Preload()
	load_area_scene_preload(115904)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
