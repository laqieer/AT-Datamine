-- このluaスクリプトは、MA_01B112_21.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_03","110141_03_h")
Include("content_adv_advsmall_110141_03","Template110141_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-58.9,CharaPos110141_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_03,CameraPos110141_03_007)
	Camera002 = SetTemplate("Actor002",-180,CharaPos110141_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_03,CameraPos110141_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110141_03,CameraPos110141_03_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_03,CameraPos110141_03_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110141_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_03,CameraPos110141_03_008)
	InitializeTemplateRandomCamera110141_03()
	InitializeTemplate110141_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
Hide(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115150)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:い、忙しいか。忙しそうだ、な
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210002")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:ふふ。どーぞ<br>ちょうど一息入れようとしていたところよ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210003")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:兄さん、休まなくて平気なの？<br>もうすぐ遠征なんでしょう？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B112_210004")

	open_select_window_tag(Actor001,"Normal","MA_01B112_210005","MA_01B112_210006","MA_01B112_210007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンの働きを見に来たんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_210009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:あくせく働いてる姿を見られるのは<br>ちょっと恥ずかしいなぁ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B112_210010")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:呼んでくれれば<br>私のほうから会いに行ったのに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B112_210011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラハッドの付き添いだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_210013")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:お似合いねえ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210014")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガラハッド★★:お、おにっ、お似合いか…？<br>そうなのか…！？
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210015")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:心が休まらなくって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_210017")

	change_face(Actor004,"Sad")

	--★★モルガン★★:休まなきゃ休まなきゃと思うとどうしてもねえ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210018")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルガン★★:なにもないところだけど<br>ゆっくりしていって
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210019")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to Bow")
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:お別れの挨拶をしにきたんだ<br>今まで世話になった
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210021")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★モルガン★★:聞きたくないなあ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:戦いに決着がついたとして<br>銀卓騎士団の行いはガラハッドにも責任がある
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルガン★★:仲間の不始末は自分の不始末だって言うの？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210025")


	--★★ガラハッド★★:銀卓騎士団は…僕の、家族だ<br>償いが必要だ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210026")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:僕だけおめおめと<br>学園生活を続けるわけにはいかない
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210027")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ガラハッド…帰って来てよ<br>私の家族を守ってくれたお礼、たくさんさせて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B112_210028")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定2")
-- ▲直接出力

	--★★モルガン★★:そうね。それがいい。私も寂しいもの<br>御礼をされるために帰って来てよ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210029")

	PlayAction(Actor003,"to  Std_Surp")

	--★★ガラハッド★★:…そんな、厚かましいことは──
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:じゃあこうしましょう<br>私の家族も守って、連れ帰って来て欲しいの
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210031")

-- ▼直接出力
 --PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサー、ですか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_210032")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★モルガン★★:アーサーが向かわなければ恐らく──
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★モルガン★★:マーリンもギネヴィア殿下も殺される<br>王に近しい彼女等をさらったのはそういうこと
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210034")

	change_face(Actor004,"Normal")

	--★★モルガン★★:ノワールくん。そういえば私のことを<br>「母さん」って呼び間違えたことあったわよね
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210036")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えッッ！？<br>なんですかいきなり！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_210037")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力

	--★★ガラハッド★★:ノワール…<br>それは恥ずかしいな…
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210038")

-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:うれしかったわ<br>くすぐったかったけど
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210039")

	change_face(Actor004,"Normal")

	--★★モルガン★★:家族作ったり…って私、ちょっと難しくって<br>だからアーサーは義理だとしても大切な弟で…
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210041")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力

	--★★モルガン★★:夢がもしもひとつ叶うならね？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210042")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★モルガン★★:私、お母さんになりたいの<br>年甲斐もないけれど
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210044")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor005,Camera005,EntryData110141_03_08,CameraAssetBundleName110141_03,CameraPos110141_03_108)
 --DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★マルディサント★★:歳なんざ関係ないっすよ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01B112_210046")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力

	--★★ガラハッド★★:うッわあ、非行少女
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210047")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:モルガンせんせはアタシたちの母さんだよ<br>少なくともアタシや…アタシの妹にとっては
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01B112_210048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:ちょっとわかるな…兄さんの気持ち<br>モルガン先生、少しだけ私たちの母さんに似てる
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B112_210049")

-- ▼直接出力
 --PlayPartVoice("モルガン", "納得")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★モルガン★★:あ、あら、あらあら
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210051")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "納得")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:そうか
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210052")

	change_face(Actor003,"Smile")

	--★★ガラハッド★★:モルガンは<br>皆のお母さんだったのか
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210053")

-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:ゆめ…叶っちゃう？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210055")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:…約束するよモルガン<br>帰って来る
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B112_210057","MA_01B112_210058","MA_01B112_210059")
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
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラハッドは<br>引っ張ってでも連れ帰りますから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_210061")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガラハッド★★:か、帰って来ると言ったはずだ！！<br>ガラハッドは約束を違えない！！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210062")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "納得")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★マルディサント★★:グズるかもしんねえもんなぁ<br>「帰りたくなぁい」ってよ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01B112_210064")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:うっ、うっ、その可能性は<br>なきにしもあらずだが………！！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210065")

	change_face(Actor003,"Anger")

	--★★ガラハッド★★:そのときは…ウン<br>ノワール、たのむぞ…っ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B112_210067")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:最強騎士がいます<br>王も護り切ってみせますから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_210069")

	change_face(Actor004,"Sad")

	--★★モルガン★★:本当はアーサーには<br>騎士を護る王でいつづけてほしいのだけれど…
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210070")

	change_face(Actor004,"Normal")

	--★★モルガン★★:なんにしても気負い過ぎないでね
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210071")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:兄さんとランス兄ちゃんがいれば<br>大丈夫です、ぜったいに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B112_210072")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:『母さん』を寂しがらせません
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_210074")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:アーサーもノワールくんも<br>みんな大切な家族よ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210075")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★モルガン★★:誰ひとり欠けることなく<br>帰って来てね
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210076")

	goto Block2end

::Block2end::
	change_face(Actor004,"Normal")

	--★★モルガン★★:ノワールくん<br>もう一度貴方に伝えさせて
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210078")


	--★★モルガン★★:抗うすべ、選び抜く道、その先の平和に<br>ノワールくん、貴方の武器が要るわ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210079")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:ふんばろうねっ<br>どんなに辛いことがあっても
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210081")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…はいっ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_210082")

-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力

	--★★モルガン★★:貴方が継承者で、本当に良かった
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01B112_210083")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115150)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
